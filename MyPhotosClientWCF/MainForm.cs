using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MyPhotos.Proxy;

namespace MyPhotosClientWCF
{
    public partial class MainForm : Form
    {
        private bool browseContext;
        private int currentIndex;
        private List<Event> events;
        private List<string> imagesList;
        private List<Landscape> landscapes;
        private List<Event> newEvents;
        private List<Landscape> newLandscapes;
        private List<Person> newPersons;
        private List<Place> newPlaces;
        private List<Person> persons;
        private List<Photo> photos;
        private List<Place> places;
        private bool searchContext;
        private List<Photo> searchedPhotos;
        private PhotoControllerClient photoControllerClient;

        public MainForm()
        {
            photos = new List<Photo>();
            InitializeComponent();
            addPerson.Visible = false;
            persons = new List<Person>();
            imagesList = new List<string>();
            events = new List<Event>();
            photoControllerClient = new PhotoControllerClient("BasicHttpBinding_IPhoto");
            var x = photoControllerClient.GetAllPersons();
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaa");
            persons = photoControllerClient.GetAllPersons().ToList();
            events = photoControllerClient.GetAllEvents().ToList();
            newPersons = new List<Person>();
            newEvents = new List<Event>();
            places = photoControllerClient.GetAllPlaces().ToList();
            newPlaces = new List<Place>();
            landscapes = photoControllerClient.GetAllLandscapes().ToList();
            newLandscapes = new List<Landscape>();
            searchedPhotos = new List<Photo>();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            browseContext = true;
            searchContext = false;

            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Media Files (*.jpg;*.jpeg;*.gif;*.png;*.mp4;*.avi;*.mov;)|*.jpg;*.jpeg;.*.gif;*.png;*.mp4;*.avi;*.mov;",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var image in openFileDialog.FileNames)
                {
                    imagesList.Add(image);

                    photos.Add(new Photo
                    {
                        Name = Path.GetFileName(image),
                        Path = Path.GetFullPath(image),
                        CreationDate = File.GetCreationTime(Path.GetFullPath(image))
                    });
                }

                DisplayPicture(imagesList.First(),
                    photos[currentIndex].Name,
                    photos[currentIndex].Path,
                    photos[currentIndex].CreationDate.ToString());

                prevPictureButton.Enabled = false;
                if (imagesList.Count == 1) nextPictureButton.Enabled = false;

                addPerson.Visible = true;
                addEventButton.Visible = true;
                addPlaceButton.Visible = true;
                addLandscapeButton.Visible = true;

                nextPictureButton.Visible = true;
                prevPictureButton.Visible = true;

                if (initialBrowseButton.Visible.Equals(true))
                {
                    initialBrowseButton.Visible = false;
                    initialPictureBox.Visible = false;
                    initialBrowseButton.Enabled = false;
                    browseButton.Visible = true;
                    InitialSearchButton.Visible = false;
                    backButton.Visible = true;
                    emailButton.Visible = true;
                    printButton.Visible = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox1.Image;
        }

        private void prevPictureButton_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                if (browseContext)
                {
                    currentIndex -= 1;
                    DisplayPicture(imagesList[currentIndex],
                        photos[currentIndex].Name,
                        photos[currentIndex].Path,
                        photos[currentIndex].CreationDate.ToString());
                }
                else if (searchContext)
                {
                    currentIndex -= 1;
                    DisplayPicture(searchedPhotos[currentIndex].Path,
                        searchedPhotos[currentIndex].Name,
                        searchedPhotos[currentIndex].Path,
                        searchedPhotos[currentIndex].CreationDate.ToString());
                    landscapesLabel.Visible = true;
                    placesLabel.Visible = true;
                    personsLabel.Visible = true;
                    eventsLabel.Visible = true;

                    DisplayPhotoDetails(searchedPhotos[currentIndex]);
                }
            }
        }

        private void nextPictureButton_Click(object sender, EventArgs e)
        {
            if (browseContext)
            {
                currentIndex += 1;
                if (currentIndex < imagesList.Count)
                    DisplayPicture(imagesList[currentIndex],
                        photos[currentIndex].Name,
                        photos[currentIndex].Path,
                        photos[currentIndex].CreationDate.ToString());
            }
            else if (searchContext)
            {
                currentIndex += 1;
                DisplayPicture(searchedPhotos[currentIndex].Path,
                    searchedPhotos[currentIndex].Name,
                    searchedPhotos[currentIndex].Path,
                    searchedPhotos[currentIndex].CreationDate.ToString());

                landscapesLabel.Visible = true;
                placesLabel.Visible = true;
                personsLabel.Visible = true;
                eventsLabel.Visible = true;

                DisplayPhotoDetails(searchedPhotos[currentIndex]);

                if (currentIndex.Equals(searchedPhotos.Count - 1)) nextPictureButton.Enabled = false;
            }
        }

        private void DisplayVideo(string video)
        {
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = true;
            axWindowsMediaPlayer1.Size = new Size(180, 180);
            axWindowsMediaPlayer1.URL = video;
            ResetFields();
            nameLabel.Visible = true;
            creationDateLabel.Visible = true;
            pathLabel.Visible = true;

            nameLabel.Text += photos[currentIndex].Name;
            creationDateLabel.Text += photos[currentIndex].CreationDate;
            pathLabel.Text += photos[currentIndex].Path;

            DisableEnableNavigationButtons(currentIndex);
        }

        private void DisplayPicture(string img, string name, string path, string creationDate)
        {
            if (img.Contains(".mp4"))
            {
                DisplayVideo(img);
            }
            else
            {
                axWindowsMediaPlayer1.Visible = false;
                pictureBox1.Visible = true;

                var image = Image.FromFile(img);

                var ratio = 5;
                if (image.Width > 1000) ratio = 10;
                var picture = new Bitmap(image, new Size(image.Width / ratio, image.Height / ratio));
                pictureBox1.Size = new Size(picture.Width, picture.Height);

                pictureBox1.Image = picture;
                nameLabel.Visible = true;
                creationDateLabel.Visible = true;
                pathLabel.Visible = true;

                ResetFields();

                nameLabel.Text += name;
                creationDateLabel.Text += creationDate;
                pathLabel.Text += path;

                DisableEnableNavigationButtons(currentIndex);
            }
        }

        private void ResetFields()
        {
            nameLabel.Text = @"Name: ";
            creationDateLabel.Text = @"Creation date: ";
            pathLabel.Text = @"Path: ";
            landscapesLabel.Text = @"Landscapes: ";
            placesLabel.Text = @"Places: ";
            personsLabel.Text = @"Persons: ";
            eventsLabel.Text = @"Events: ";

            landscapesLabel.Visible = false;
            placesLabel.Visible = false;
            personsLabel.Visible = false;
            eventsLabel.Visible = false;
        }


        private void DisableEnableNavigationButtons(int index)
        {
            if (index.Equals(0))
            {
                if (searchedPhotos.Count.Equals(1) || imagesList.Count.Equals(1))
                {
                    prevPictureButton.Enabled = false;
                    nextPictureButton.Enabled = false;
                }
                else
                {
                    prevPictureButton.Enabled = false;
                    nextPictureButton.Enabled = true;
                }
            }
            else if (index.Equals(imagesList.Count - 1))
            {
                nextPictureButton.Enabled = false;
                prevPictureButton.Enabled = true;
            }
            else
            {
                prevPictureButton.Enabled = true;
                nextPictureButton.Enabled = true;
            }
        }

        private void addPerson_Click(object sender, EventArgs e)
        {
            personComboBox.Items.Clear();
            addPerson.Enabled = false;
            personComboBox.Visible = true;
            selectAnOptionPersonLabel.Visible = true;

            foreach (var person in persons) personComboBox.Items.Add(person.FirstName + " " + person.LastName);

            personComboBox.Items.Add("Add a new person");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = personComboBox.SelectedItem;

            if (selection.Equals("Add a new person"))
            {
                savePersonButton.Location = new Point(290, 170);
                savePersonButton.Visible = true;
                firstNameLabel.Visible = true;
                lastNameLabel.Visible = true;
                firstNameTextBox.Visible = true;
                lastNameTextBox.Visible = true;
            }
            else if (!selection.Equals("(Select an option)"))
            {
                savePersonButton.Location = new Point(290, 90);
                savePersonButton.Visible = true;
                savePersonButton.Enabled = true;

                firstNameLabel.Visible = false;
                lastNameLabel.Visible = false;
                firstNameTextBox.Visible = false;
                lastNameTextBox.Visible = false;
            }
        }


        private void firstNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (firstNameTextBox.Text.Equals("Example: John")) firstNameTextBox.Clear();
        }

        private void lastNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (lastNameTextBox.Text.Equals("Example: Doe")) lastNameTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initialBrowseButton.Location = new Point(100, 390);
            initialPictureBox.Location = new Point(270, 50);
            initialPictureBox.Visible = true;
            InitialSearchButton.Visible = true;
            InitialSearchButton.Location = new Point(450, 390);

            var image = Image.FromFile("C:\\Users\\dghiuzan\\OneDrive - ENDAVA\\Desktop\\My-Pictures-icon.png");
            initialPictureBox.Size = new Size(image.Width, image.Height);
            initialPictureBox.Image = image;
            backButton.Visible = false;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var nameRestrictions = new List<string>
            {
                "", "Example: John", "Example: Doe", " ", ",", ".", "#", "!", "$", "%", "^", "&", "*", "@"
            };
            if (!nameRestrictions.Contains(firstNameTextBox.Text) &&
                !nameRestrictions.Contains(firstNameTextBox.Text))
                savePersonButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (personComboBox.SelectedItem.Equals("Add a new person"))
            {
                var newPerson = new Person
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text
                };
                persons.Add(newPerson);
                newPersons.Add(newPerson);

                DisplayNewPersons(newPerson);
            }
            else
            {
                foreach (var person in persons)
                    if ((person.FirstName + " " + person.LastName).Equals(personComboBox.Text))
                        newPersons.Add(person);

                DisplayExistingPerson(personComboBox.Text);
            }

            ResetAddPersonFields();
        }

        private void ResetAddPersonFields()
        {
            addPerson.Enabled = true;
            personComboBox.Visible = false;
            selectAnOptionPersonLabel.Visible = false;
            firstNameLabel.Visible = false;
            lastNameLabel.Visible = false;
            firstNameTextBox.Visible = false;
            lastNameTextBox.Visible = false;
            savePersonButton.Visible = false;
            savePersonButton.Enabled = false;
        }

        private void ResetAddEventFields()
        {
            addEventButton.Enabled = true;
            eventComboBox.Visible = false;
            selectAnOptionEventLabel.Visible = false;
            eventNameLabel.Visible = false;
            eventDescriptionLabel.Visible = false;
            eventDateLabel.Visible = false;
            eventNameTextBox.Visible = false;
            eventDescriptionTextBox.Visible = false;
            eventDatePicker.Visible = false;
            saveEventButton.Visible = false;
            saveEventButton.Enabled = false;
        }

        private void ResetAddPlaceFields()
        {
            addPlaceButton.Enabled = true;
            placeComboBox.Visible = false;
            selectAnOptionPlaceLabel.Visible = false;
            placeNameLabel.Visible = false;
            placeDescriptionLabel.Visible = false;
            placeAddressLabel.Visible = false;
            placeNameTextBox.Visible = false;
            placeDescriptionTextBox.Visible = false;
            placeAddressTextBox.Visible = false;
            savePlaceButton.Visible = false;
            savePlaceButton.Enabled = false;
        }

        private void ResetAddLandscapeFields()
        {
            addLandscapeButton.Enabled = true;
            landscapeComboBox.Visible = false;
            selectAnOptionLandscapeLabel.Visible = false;
            landscapeNameLabel.Visible = false;
            landscapeDescripitonLabel.Visible = false;
            landscapeNameTextBox.Visible = false;
            landscapeDescriptionTextBox.Visible = false;
            saveLandscapeButton.Visible = false;
            saveLandscapeButton.Enabled = false;
        }

        private void DisplayExistingPerson(string name)
        {
            personsLabel.Visible = true;
            if (personsLabel.Text.Equals("Persons: "))
                personsLabel.Text += name;
            else
                personsLabel.Text += @", " + name;

            DisplaySavePhotoButton(true);
        }

        private void DisplayNewEvent(string eventToDisplay)
        {
            eventsLabel.Visible = true;
            if (eventsLabel.Text.Equals("Events: "))
                eventsLabel.Text += eventToDisplay;
            else
                eventsLabel.Text += @", " + eventToDisplay;

            DisplaySavePhotoButton(true);
        }

        private void DisplayNewPlace(string place)
        {
            placesLabel.Visible = true;
            if (placesLabel.Text.Equals("Places: "))
                placesLabel.Text += place;
            else
                placesLabel.Text += @", " + place;

            DisplaySavePhotoButton(true);
        }

        private void DisplayNewLandscape(string landscape)
        {
            landscapesLabel.Visible = true;
            if (landscapesLabel.Text.Equals("Landscapes: "))
                landscapesLabel.Text += landscape;
            else
                landscapesLabel.Text += @", " + landscape;

            DisplaySavePhotoButton(true);
        }

        private void DisplaySavePhotoButton(bool display)
        {
            if (landscapesLabel.Visible
                && placesLabel.Visible
                && personsLabel.Visible
                && eventsLabel.Visible)
            {
                savePhotoButton.Visible = display;
                savePhotoButton.Enabled = display;
            }
        }

        private void DisplayNewPersons(Person person)
        {
            personsLabel.Visible = true;
            if (personsLabel.Text.Equals("Persons: "))
                personsLabel.Text += person.FirstName + @" " + person.LastName;
            else
                personsLabel.Text += @", " + person.FirstName + @" " + person.LastName;

            DisplaySavePhotoButton(true);
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            eventComboBox.Items.Clear();
            addEventButton.Enabled = false;
            eventComboBox.Visible = true;
            selectAnOptionEventLabel.Visible = true;

            foreach (var ev in events) eventComboBox.Items.Add(ev.Name);

            eventComboBox.Items.Add("Add a new event");
        }

        private void eventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = eventComboBox.SelectedItem;

            if (selection.Equals("Add a new event"))
            {
                saveEventButton.Location = new Point(420, 200);
                saveEventButton.Visible = true;
                eventNameLabel.Visible = true;
                eventDescriptionLabel.Visible = true;
                eventDateLabel.Visible = true;
                eventNameTextBox.Visible = true;
                eventDescriptionTextBox.Visible = true;
                eventDatePicker.Visible = true;
            }
            else if (!selection.Equals("(Select an option)"))
            {
                saveEventButton.Location = new Point(420, 90);
                saveEventButton.Visible = true;
                saveEventButton.Enabled = true;

                eventNameLabel.Visible = false;
                eventDescriptionLabel.Visible = false;
                eventDateLabel.Visible = false;
                eventNameTextBox.Visible = false;
                eventDescriptionTextBox.Visible = false;
                eventDatePicker.Visible = false;
            }
        }

        private void eventNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var nameRestrictions = new List<string>
            {
                "", "Example: Graduation", "Example: 2020 graduation", " ", ",", ".", "#", "!", "$", "%", "^", "&", "*",
                "@"
            };
            if (!nameRestrictions.Contains(eventNameTextBox.Text)
                && eventDescriptionTextBox.Text != ""
                && eventDatePicker.Checked)
                saveEventButton.Enabled = true;
        }

        private void eventNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (eventNameTextBox.Text.Equals("Example: Graduation")) eventNameTextBox.Clear();
        }

        private void eventDescriptionTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (eventDescriptionTextBox.Text.Equals("Example: 2020 graduation")) eventDescriptionTextBox.Clear();
        }

        private void saveEventButton_Click(object sender, EventArgs e)
        {
            if (eventComboBox.SelectedItem.Equals("Add a new event"))
            {
                var newEvent = new Event
                {
                    Name = eventNameTextBox.Text,
                    Description = eventDescriptionTextBox.Text,
                    Date = eventDatePicker.Value
                };

                events.Add(newEvent);
                newEvents.Add(newEvent);

                DisplayNewEvent(newEvent.Name);
            }
            else
            {
                DisplayNewEvent(eventComboBox.Text);

                foreach (var ev in events)
                    if (ev.Name.Equals(eventComboBox.Text))
                        newEvents.Add(ev);
            }

            ResetAddEventFields();
        }

        private void eventDatePicker_ValueChanged(object sender, EventArgs e)
        {
        }

        private void addPlaceButton_Click(object sender, EventArgs e)
        {
            placeComboBox.Items.Clear();
            addPlaceButton.Enabled = false;
            placeComboBox.Visible = true;
            selectAnOptionPlaceLabel.Visible = true;

            foreach (var place in places) placeComboBox.Items.Add(place.Name);

            placeComboBox.Items.Add("Add a new place");
        }

        private void placeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = placeComboBox.SelectedItem;

            if (selection.Equals("Add a new place"))
            {
                savePlaceButton.Location = new Point(555, 200);
                savePlaceButton.Visible = true;
                placeNameLabel.Visible = true;
                placeDescriptionLabel.Visible = true;
                placeAddressLabel.Visible = true;
                placeNameTextBox.Visible = true;
                placeDescriptionTextBox.Visible = true;
                placeAddressTextBox.Visible = true;
            }
            else if (!selection.Equals("(Select an option)"))
            {
                savePlaceButton.Location = new Point(555, 90);
                savePlaceButton.Visible = true;
                savePlaceButton.Enabled = true;

                placeNameLabel.Visible = false;
                placeDescriptionLabel.Visible = false;
                placeAddressLabel.Visible = false;
                placeNameTextBox.Visible = false;
                placeDescriptionTextBox.Visible = false;
                placeAddressTextBox.Visible = false;
            }
        }

        private void placeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var nameRestrictions = new List<string>
            {
                "", "Example: Palace of Culture", "Example: Beautiful place", " ", ",", ".", "#", "!", "$", "%", "^",
                "&", "*", "@"
            };
            if (!nameRestrictions.Contains(placeNameTextBox.Text)
                && placeDescriptionTextBox.Text != ""
                && placeAddressTextBox.Text != "")
                savePlaceButton.Enabled = true;
        }

        private void savePlaceButton_Click(object sender, EventArgs e)
        {
            if (placeComboBox.SelectedItem.Equals("Add a new place"))
            {
                var newPlace = new Place
                {
                    Name = placeNameTextBox.Text,
                    Description = placeDescriptionTextBox.Text,
                    Address = placeAddressTextBox.Text
                };

                places.Add(newPlace);
                newPlaces.Add(newPlace);

                DisplayNewPlace(newPlace.Name);
            }
            else
            {
                DisplayNewPlace(placeComboBox.Text);
            }

            ResetAddPlaceFields();
        }

        private void addLandscapeButton_Click(object sender, EventArgs e)
        {
            landscapeComboBox.Items.Clear();
            addLandscapeButton.Enabled = false;
            landscapeComboBox.Visible = true;
            selectAnOptionLandscapeLabel.Visible = true;

            foreach (var landscape in landscapes) landscapeComboBox.Items.Add(landscape.Name);

            landscapeComboBox.Items.Add("Add a new landscape");
        }

        private void landscapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selection = landscapeComboBox.SelectedItem;

            if (selection.Equals("Add a new landscape"))
            {
                saveLandscapeButton.Location = new Point(690, 170);
                saveLandscapeButton.Visible = true;
                landscapeNameLabel.Visible = true;
                landscapeDescripitonLabel.Visible = true;
                landscapeNameTextBox.Visible = true;
                landscapeDescriptionTextBox.Visible = true;
            }
            else if (!selection.Equals("(Select an option)"))
            {
                saveLandscapeButton.Location = new Point(690, 90);
                saveLandscapeButton.Visible = true;
                saveLandscapeButton.Enabled = true;

                landscapeNameLabel.Visible = false;
                landscapeDescripitonLabel.Visible = false;
                landscapeNameTextBox.Visible = false;
                landscapeDescriptionTextBox.Visible = false;
            }
        }

        private void landscapeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var nameRestrictions = new List<string>
            {
                "", "Example: Sunrise", "Example: Beautiful view", " ", ",", ".", "#", "!", "$", "%", "^", "&", "*", "@"
            };
            if (!nameRestrictions.Contains(landscapeNameTextBox.Text)
                && landscapeDescriptionTextBox.Text != "")
                saveLandscapeButton.Enabled = true;
        }

        private void placeNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            placeNameTextBox.Clear();
        }

        private void placeDescriptionTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            placeDescriptionTextBox.Clear();
        }

        private void placeAddressTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            placeAddressTextBox.Clear();
        }

        private void landscapeNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            landscapeNameTextBox.Clear();
        }

        private void landscapeDescriptionTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            landscapeDescriptionTextBox.Clear();
        }

        private void saveLandscapeButton_Click(object sender, EventArgs e)
        {
            if (landscapeComboBox.SelectedItem.Equals("Add a new landscape"))
            {
                var newLandscape = new Landscape
                {
                    Name = landscapeNameTextBox.Text,
                    Description = landscapeDescriptionTextBox.Text
                };

                landscapes.Add(newLandscape);
                newLandscapes.Add(newLandscape);

                DisplayNewLandscape(newLandscape.Name);
            }
            else
            {
                DisplayNewLandscape(landscapeComboBox.Text);
            }

            ResetAddLandscapeFields();
        }

        private void savePhotoButton_Click(object sender, EventArgs e)
        {
            var photoToAdd = photos[currentIndex];
            photoToAdd.Events = newEvents.ToArray();
            photoToAdd.Persons = newPersons.ToArray();
            photoToAdd.Landscapes = newLandscapes.ToArray();
            photoToAdd.Places = newPlaces.ToArray();

            photoControllerClient.AddOrUpdatePhoto(photoToAdd);
            var warningChoice = MessageBox.Show(@"Photo successfully saved",
                @"Save",
                MessageBoxButtons.OK,
                MessageBoxIcon.None);
            savePhotoButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchContext = true;
            browseContext = false;

            searchButton.Visible = true;
            searchTextBox.Visible = true;
            searchTextBox.Location = new Point(20, 20);
            searchButton.Location = new Point(170, 20);

            initialPictureBox.Visible = false;
            InitialSearchButton.Visible = false;
            initialBrowseButton.Visible = false;
        }

        private void searchTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            searchTextBox.Clear();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (searchTextBox.Text != "") searchButton.Enabled = true;
        }

        private void DisplayImageFromDatabasePath()
        {
            var file = searchedPhotos.First();
            DisplayPicture(file.Path,
                file.Name,
                file.Path,
                file.CreationDate.ToString());

            DisplayPhotoDetails(file);
        }

        private void DisplayPhotoDetails(Photo photoDetails)
        {
            foreach (var fileEvent in photoDetails.Events) DisplayNewEvent(fileEvent.Name);

            foreach (var filePerson in photoDetails.Persons) DisplayNewPersons(filePerson);

            foreach (var filePlace in photoDetails.Places) DisplayNewPlace(filePlace.Name);
            foreach (var fileLandscape in photoDetails.Landscapes) DisplayNewLandscape(fileLandscape.Name);
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            searchedPhotos = photoControllerClient.SearchPhotoByText(searchTextBox.Text).ToList();
            photos = searchedPhotos;

            if (searchedPhotos.Count != 0)
            {
                prevPictureButton.Enabled = false;
                if (searchedPhotos.Count == 1)
                    nextPictureButton.Enabled = false;
                else
                    nextPictureButton.Enabled = true;

                DisplayImageFromDatabasePath();
                addPerson.Visible = true;
                addEventButton.Visible = true;
                addPlaceButton.Visible = true;
                addLandscapeButton.Visible = true;
                nextPictureButton.Visible = true;
                prevPictureButton.Visible = true;
                backButton.Visible = true;
                deleteButton.Visible = true;
                emailButton.Visible = true;
                printButton.Visible = true;
            }
            else
            {
                noResultsfooundLabel.Location = new Point(20, 20);
                noResultsfooundLabel.Visible = true;
                backButton.Visible = true;
            }

            initialPictureBox.Visible = false;
            InitialSearchButton.Visible = false;
            searchButton.Visible = false;
            searchTextBox.Visible = false;
            initialBrowseButton.Visible = false;
        }

        private void ResetAddPhotoFields()
        {
            pictureBox1.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            prevPictureButton.Visible = false;
            nextPictureButton.Visible = false;
            browseButton.Visible = false;
            nameLabel.Visible = false;
            pathLabel.Visible = false;
            creationDateLabel.Visible = false;
            addPerson.Visible = false;
            addEventButton.Visible = false;
            personsLabel.Visible = false;
            eventsLabel.Visible = false;
            placesLabel.Visible = false;
            landscapesLabel.Visible = false;
            addPlaceButton.Visible = false;
            addLandscapeButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ResetAddPersonFields();
            ResetAddEventFields();
            ResetAddLandscapeFields();
            ResetAddPlaceFields();
            ResetAddPhotoFields();
            initialBrowseButton.Visible = true;
            InitialSearchButton.Visible = true;
            initialBrowseButton.Enabled = true;
            InitialSearchButton.Enabled = true;
            initialPictureBox.Visible = true;
            noResultsfooundLabel.Visible = false;
            backButton.Visible = false;
            savePhotoButton.Visible = false;
            ResetAllObjects();
        }

        private void ResetAllObjects()
        {
            photos = new List<Photo>();
            addPerson.Visible = false;
            persons = new List<Person>();
            imagesList = new List<string>();
            photoControllerClient = new PhotoControllerClient();
            events = new List<Event>();
            persons = photoControllerClient.GetAllPersons().ToList();
            events = photoControllerClient.GetAllEvents().ToList();
            newPersons = new List<Person>();
            newEvents = new List<Event>();
            places = photoControllerClient.GetAllPlaces().ToList();
            newPlaces = new List<Place>();
            landscapes = photoControllerClient.GetAllLandscapes().ToList();
            newLandscapes = new List<Landscape>();
            currentIndex = 0;
            searchedPhotos = new List<Photo>();
            emailButton.Visible = false;
            printButton.Visible = false;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var warningChoice = MessageBox.Show(@"Are you sure you want to delete this photo?",
                @"Delete photo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (warningChoice.Equals(DialogResult.OK))
            {
                photoControllerClient.DeletePhoto(searchedPhotos[currentIndex]);
                deleteButton.Visible = false;

                backButton.Visible = false;
                ResetAddPersonFields();
                ResetAddEventFields();
                ResetAddLandscapeFields();
                ResetAddPlaceFields();
                ResetAddPhotoFields();
                initialBrowseButton.Visible = true;
                InitialSearchButton.Visible = true;
                initialBrowseButton.Enabled = true;
                InitialSearchButton.Enabled = true;
                initialPictureBox.Visible = true;
                noResultsfooundLabel.Visible = false;
                savePhotoButton.Visible = false;
                savePhotoButton.Enabled = false;
                ResetAllObjects();
            }
        }

        private void emailButton_Click(object sender, EventArgs e)
        {
            var email = new EmailForm(photos[currentIndex].Path);
            email.Show();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument myPrintDocument = new PrintDocument();

            PrintDialog myPrintDialog = new PrintDialog();

            myPrintDocument.PrintPage += new PrintPageEventHandler(Doc_PrintPage);

            myPrintDialog.Document = myPrintDocument;

            if (myPrintDialog.ShowDialog() == DialogResult.OK)
            {
                myPrintDocument.Print();
            }
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Print image
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
    }
}