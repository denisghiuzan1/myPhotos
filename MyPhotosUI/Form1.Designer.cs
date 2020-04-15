namespace MyPhotosUI
{
    partial class MyPhotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPhotos));
            this.browseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.prevPictureButton = new System.Windows.Forms.Button();
            this.nextPictureButton = new System.Windows.Forms.Button();
            this.addPerson = new System.Windows.Forms.Button();
            this.personComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.selectAnOptionPersonLabel = new System.Windows.Forms.Label();
            this.initialBrowseButton = new System.Windows.Forms.Button();
            this.personsLabel = new System.Windows.Forms.Label();
            this.eventsLabel = new System.Windows.Forms.Label();
            this.landscapesLabel = new System.Windows.Forms.Label();
            this.placesLabel = new System.Windows.Forms.Label();
            this.savePersonButton = new System.Windows.Forms.Button();
            this.saveEventButton = new System.Windows.Forms.Button();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventNameTextBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.savePlaceButton = new System.Windows.Forms.Button();
            this.selectAnOptionPlaceLabel = new System.Windows.Forms.Label();
            this.placeAddressTextBox = new System.Windows.Forms.TextBox();
            this.placeNameTextBox = new System.Windows.Forms.TextBox();
            this.placeComboBox = new System.Windows.Forms.ComboBox();
            this.addPlaceButton = new System.Windows.Forms.Button();
            this.saveLandscapeButton = new System.Windows.Forms.Button();
            this.selectAnOptionLandscapeLabel = new System.Windows.Forms.Label();
            this.landscapeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.landscapeNameTextBox = new System.Windows.Forms.TextBox();
            this.landscapeComboBox = new System.Windows.Forms.ComboBox();
            this.addLandscapeButton = new System.Windows.Forms.Button();
            this.eventDescriptionLabel = new System.Windows.Forms.Label();
            this.eventDatePicker = new System.Windows.Forms.DateTimePicker();
            this.eventDateLabel = new System.Windows.Forms.Label();
            this.selectAnOptionEventLabel = new System.Windows.Forms.Label();
            this.eventComboBox = new System.Windows.Forms.ComboBox();
            this.placeDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeDescriptionLabel = new System.Windows.Forms.Label();
            this.placeAddressLabel = new System.Windows.Forms.Label();
            this.landscapeNameLabel = new System.Windows.Forms.Label();
            this.landscapeDescripitonLabel = new System.Windows.Forms.Label();
            this.initialPictureBox = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.savePhotoButton = new System.Windows.Forms.Button();
            this.InitialSearchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.noResultsfooundLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(28, 16);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 31);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Visible = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(28, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 243);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(28, 308);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(85, 27);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name: ";
            this.nameLabel.Visible = false;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.Location = new System.Drawing.Point(29, 350);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(135, 22);
            this.creationDateLabel.TabIndex = 4;
            this.creationDateLabel.Text = "Creation Date: ";
            this.creationDateLabel.Visible = false;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(29, 381);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(58, 22);
            this.pathLabel.TabIndex = 6;
            this.pathLabel.Text = "Path: ";
            this.pathLabel.Visible = false;
            // 
            // prevPictureButton
            // 
            this.prevPictureButton.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPictureButton.Location = new System.Drawing.Point(187, 16);
            this.prevPictureButton.Name = "prevPictureButton";
            this.prevPictureButton.Size = new System.Drawing.Size(31, 31);
            this.prevPictureButton.TabIndex = 7;
            this.prevPictureButton.Text = "<";
            this.prevPictureButton.UseVisualStyleBackColor = true;
            this.prevPictureButton.Visible = false;
            this.prevPictureButton.Click += new System.EventHandler(this.prevPictureButton_Click);
            // 
            // nextPictureButton
            // 
            this.nextPictureButton.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextPictureButton.Location = new System.Drawing.Point(234, 16);
            this.nextPictureButton.Name = "nextPictureButton";
            this.nextPictureButton.Size = new System.Drawing.Size(31, 31);
            this.nextPictureButton.TabIndex = 8;
            this.nextPictureButton.Text = ">";
            this.nextPictureButton.UseVisualStyleBackColor = true;
            this.nextPictureButton.Visible = false;
            this.nextPictureButton.Click += new System.EventHandler(this.nextPictureButton_Click);
            // 
            // addPerson
            // 
            this.addPerson.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addPerson.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPerson.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPerson.Location = new System.Drawing.Point(295, 16);
            this.addPerson.Name = "addPerson";
            this.addPerson.Size = new System.Drawing.Size(161, 38);
            this.addPerson.TabIndex = 10;
            this.addPerson.Text = "Add Person";
            this.addPerson.UseVisualStyleBackColor = false;
            this.addPerson.Click += new System.EventHandler(this.addPerson_Click);
            // 
            // personComboBox
            // 
            this.personComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.personComboBox.FormattingEnabled = true;
            this.personComboBox.Location = new System.Drawing.Point(296, 77);
            this.personComboBox.Name = "personComboBox";
            this.personComboBox.Size = new System.Drawing.Size(160, 24);
            this.personComboBox.TabIndex = 11;
            this.personComboBox.Text = "(Select an option)";
            this.personComboBox.Visible = false;
            this.personComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.firstNameTextBox.Location = new System.Drawing.Point(296, 124);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.firstNameTextBox.TabIndex = 12;
            this.firstNameTextBox.Text = "Example: John";
            this.firstNameTextBox.Visible = false;
            this.firstNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.firstNameTextBox_MouseClick);
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lastNameTextBox.Location = new System.Drawing.Point(296, 170);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.lastNameTextBox.TabIndex = 13;
            this.lastNameTextBox.Text = "Example: Doe";
            this.lastNameTextBox.Visible = false;
            this.lastNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lastNameTextBox_MouseClick);
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.firstNameTextBox_TextChanged);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(293, 104);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 14;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.Visible = false;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(293, 150);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 15;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.Visible = false;
            // 
            // selectAnOptionPersonLabel
            // 
            this.selectAnOptionPersonLabel.AutoSize = true;
            this.selectAnOptionPersonLabel.Location = new System.Drawing.Point(293, 55);
            this.selectAnOptionPersonLabel.Name = "selectAnOptionPersonLabel";
            this.selectAnOptionPersonLabel.Size = new System.Drawing.Size(110, 17);
            this.selectAnOptionPersonLabel.TabIndex = 16;
            this.selectAnOptionPersonLabel.Text = "Select an option";
            this.selectAnOptionPersonLabel.Visible = false;
            // 
            // initialBrowseButton
            // 
            this.initialBrowseButton.Location = new System.Drawing.Point(404, 567);
            this.initialBrowseButton.Name = "initialBrowseButton";
            this.initialBrowseButton.Size = new System.Drawing.Size(287, 70);
            this.initialBrowseButton.TabIndex = 17;
            this.initialBrowseButton.Text = "Browse...";
            this.initialBrowseButton.UseVisualStyleBackColor = true;
            this.initialBrowseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // personsLabel
            // 
            this.personsLabel.AutoSize = true;
            this.personsLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personsLabel.Location = new System.Drawing.Point(29, 414);
            this.personsLabel.Name = "personsLabel";
            this.personsLabel.Size = new System.Drawing.Size(86, 22);
            this.personsLabel.TabIndex = 18;
            this.personsLabel.Text = "Persons: ";
            this.personsLabel.Visible = false;
            // 
            // eventsLabel
            // 
            this.eventsLabel.AutoSize = true;
            this.eventsLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsLabel.Location = new System.Drawing.Point(29, 445);
            this.eventsLabel.Name = "eventsLabel";
            this.eventsLabel.Size = new System.Drawing.Size(76, 22);
            this.eventsLabel.TabIndex = 19;
            this.eventsLabel.Text = "Events: ";
            this.eventsLabel.Visible = false;
            // 
            // landscapesLabel
            // 
            this.landscapesLabel.AutoSize = true;
            this.landscapesLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landscapesLabel.Location = new System.Drawing.Point(29, 500);
            this.landscapesLabel.Name = "landscapesLabel";
            this.landscapesLabel.Size = new System.Drawing.Size(118, 22);
            this.landscapesLabel.TabIndex = 20;
            this.landscapesLabel.Text = "Landscapes: ";
            this.landscapesLabel.Visible = false;
            // 
            // placesLabel
            // 
            this.placesLabel.AutoSize = true;
            this.placesLabel.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placesLabel.Location = new System.Drawing.Point(30, 476);
            this.placesLabel.Name = "placesLabel";
            this.placesLabel.Size = new System.Drawing.Size(75, 22);
            this.placesLabel.TabIndex = 21;
            this.placesLabel.Text = "Places: ";
            this.placesLabel.Visible = false;
            // 
            // savePersonButton
            // 
            this.savePersonButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.savePersonButton.Enabled = false;
            this.savePersonButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePersonButton.Location = new System.Drawing.Point(384, 199);
            this.savePersonButton.Name = "savePersonButton";
            this.savePersonButton.Size = new System.Drawing.Size(72, 29);
            this.savePersonButton.TabIndex = 22;
            this.savePersonButton.Text = "Save";
            this.savePersonButton.UseVisualStyleBackColor = false;
            this.savePersonButton.Visible = false;
            this.savePersonButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveEventButton
            // 
            this.saveEventButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveEventButton.Enabled = false;
            this.saveEventButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEventButton.Location = new System.Drawing.Point(560, 243);
            this.saveEventButton.Name = "saveEventButton";
            this.saveEventButton.Size = new System.Drawing.Size(72, 29);
            this.saveEventButton.TabIndex = 28;
            this.saveEventButton.Text = "Save";
            this.saveEventButton.UseVisualStyleBackColor = false;
            this.saveEventButton.Visible = false;
            this.saveEventButton.Click += new System.EventHandler(this.saveEventButton_Click);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Location = new System.Drawing.Point(469, 103);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(45, 17);
            this.eventNameLabel.TabIndex = 27;
            this.eventNameLabel.Text = "Name";
            this.eventNameLabel.Visible = false;
            // 
            // eventDescriptionTextBox
            // 
            this.eventDescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.eventDescriptionTextBox.Location = new System.Drawing.Point(472, 168);
            this.eventDescriptionTextBox.Name = "eventDescriptionTextBox";
            this.eventDescriptionTextBox.Size = new System.Drawing.Size(160, 22);
            this.eventDescriptionTextBox.TabIndex = 26;
            this.eventDescriptionTextBox.Text = "Example: 2020 graduation";
            this.eventDescriptionTextBox.Visible = false;
            this.eventDescriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventDescriptionTextBox_MouseClick);
            this.eventDescriptionTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // eventNameTextBox
            // 
            this.eventNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.eventNameTextBox.Location = new System.Drawing.Point(472, 123);
            this.eventNameTextBox.Name = "eventNameTextBox";
            this.eventNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.eventNameTextBox.TabIndex = 25;
            this.eventNameTextBox.Text = "Example: Graduation";
            this.eventNameTextBox.Visible = false;
            this.eventNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eventNameTextBox_MouseClick);
            this.eventNameTextBox.TextChanged += new System.EventHandler(this.eventNameTextBox_TextChanged);
            // 
            // addEventButton
            // 
            this.addEventButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addEventButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addEventButton.Location = new System.Drawing.Point(471, 16);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(161, 38);
            this.addEventButton.TabIndex = 23;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = false;
            this.addEventButton.Visible = false;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // savePlaceButton
            // 
            this.savePlaceButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.savePlaceButton.Enabled = false;
            this.savePlaceButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePlaceButton.Location = new System.Drawing.Point(737, 243);
            this.savePlaceButton.Name = "savePlaceButton";
            this.savePlaceButton.Size = new System.Drawing.Size(72, 29);
            this.savePlaceButton.TabIndex = 34;
            this.savePlaceButton.Text = "Save";
            this.savePlaceButton.UseVisualStyleBackColor = false;
            this.savePlaceButton.Visible = false;
            this.savePlaceButton.Click += new System.EventHandler(this.savePlaceButton_Click);
            // 
            // selectAnOptionPlaceLabel
            // 
            this.selectAnOptionPlaceLabel.AutoSize = true;
            this.selectAnOptionPlaceLabel.Location = new System.Drawing.Point(646, 55);
            this.selectAnOptionPlaceLabel.Name = "selectAnOptionPlaceLabel";
            this.selectAnOptionPlaceLabel.Size = new System.Drawing.Size(110, 17);
            this.selectAnOptionPlaceLabel.TabIndex = 33;
            this.selectAnOptionPlaceLabel.Text = "Select an option";
            this.selectAnOptionPlaceLabel.Visible = false;
            // 
            // placeAddressTextBox
            // 
            this.placeAddressTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.placeAddressTextBox.Location = new System.Drawing.Point(649, 211);
            this.placeAddressTextBox.Name = "placeAddressTextBox";
            this.placeAddressTextBox.Size = new System.Drawing.Size(160, 22);
            this.placeAddressTextBox.TabIndex = 32;
            this.placeAddressTextBox.Text = "Example: 23 Sesame st.";
            this.placeAddressTextBox.Visible = false;
            this.placeAddressTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placeAddressTextBox_MouseClick);
            this.placeAddressTextBox.TextChanged += new System.EventHandler(this.placeNameTextBox_TextChanged);
            // 
            // placeNameTextBox
            // 
            this.placeNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.placeNameTextBox.Location = new System.Drawing.Point(649, 124);
            this.placeNameTextBox.Name = "placeNameTextBox";
            this.placeNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.placeNameTextBox.TabIndex = 31;
            this.placeNameTextBox.Text = "Example: Palace of Culture";
            this.placeNameTextBox.Visible = false;
            this.placeNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placeNameTextBox_MouseClick);
            this.placeNameTextBox.TextChanged += new System.EventHandler(this.placeNameTextBox_TextChanged);
            // 
            // placeComboBox
            // 
            this.placeComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.placeComboBox.FormattingEnabled = true;
            this.placeComboBox.Location = new System.Drawing.Point(649, 77);
            this.placeComboBox.Name = "placeComboBox";
            this.placeComboBox.Size = new System.Drawing.Size(160, 24);
            this.placeComboBox.TabIndex = 30;
            this.placeComboBox.Text = "(Select an option)";
            this.placeComboBox.Visible = false;
            this.placeComboBox.SelectedIndexChanged += new System.EventHandler(this.placeComboBox_SelectedIndexChanged);
            // 
            // addPlaceButton
            // 
            this.addPlaceButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addPlaceButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPlaceButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addPlaceButton.Location = new System.Drawing.Point(648, 16);
            this.addPlaceButton.Name = "addPlaceButton";
            this.addPlaceButton.Size = new System.Drawing.Size(161, 38);
            this.addPlaceButton.TabIndex = 29;
            this.addPlaceButton.Text = "Add Place";
            this.addPlaceButton.UseVisualStyleBackColor = false;
            this.addPlaceButton.Visible = false;
            this.addPlaceButton.Click += new System.EventHandler(this.addPlaceButton_Click);
            // 
            // saveLandscapeButton
            // 
            this.saveLandscapeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveLandscapeButton.Enabled = false;
            this.saveLandscapeButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLandscapeButton.Location = new System.Drawing.Point(913, 199);
            this.saveLandscapeButton.Name = "saveLandscapeButton";
            this.saveLandscapeButton.Size = new System.Drawing.Size(72, 29);
            this.saveLandscapeButton.TabIndex = 40;
            this.saveLandscapeButton.Text = "Save";
            this.saveLandscapeButton.UseVisualStyleBackColor = false;
            this.saveLandscapeButton.Visible = false;
            this.saveLandscapeButton.Click += new System.EventHandler(this.saveLandscapeButton_Click);
            // 
            // selectAnOptionLandscapeLabel
            // 
            this.selectAnOptionLandscapeLabel.AutoSize = true;
            this.selectAnOptionLandscapeLabel.Location = new System.Drawing.Point(822, 55);
            this.selectAnOptionLandscapeLabel.Name = "selectAnOptionLandscapeLabel";
            this.selectAnOptionLandscapeLabel.Size = new System.Drawing.Size(110, 17);
            this.selectAnOptionLandscapeLabel.TabIndex = 39;
            this.selectAnOptionLandscapeLabel.Text = "Select an option";
            this.selectAnOptionLandscapeLabel.Visible = false;
            // 
            // landscapeDescriptionTextBox
            // 
            this.landscapeDescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.landscapeDescriptionTextBox.Location = new System.Drawing.Point(825, 170);
            this.landscapeDescriptionTextBox.Name = "landscapeDescriptionTextBox";
            this.landscapeDescriptionTextBox.Size = new System.Drawing.Size(160, 22);
            this.landscapeDescriptionTextBox.TabIndex = 38;
            this.landscapeDescriptionTextBox.Text = "Example: Beautiful view";
            this.landscapeDescriptionTextBox.Visible = false;
            this.landscapeDescriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.landscapeDescriptionTextBox_MouseClick);
            this.landscapeDescriptionTextBox.TextChanged += new System.EventHandler(this.landscapeNameTextBox_TextChanged);
            // 
            // landscapeNameTextBox
            // 
            this.landscapeNameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.landscapeNameTextBox.Location = new System.Drawing.Point(825, 124);
            this.landscapeNameTextBox.Name = "landscapeNameTextBox";
            this.landscapeNameTextBox.Size = new System.Drawing.Size(160, 22);
            this.landscapeNameTextBox.TabIndex = 37;
            this.landscapeNameTextBox.Text = "Example: Sunrise";
            this.landscapeNameTextBox.Visible = false;
            this.landscapeNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.landscapeNameTextBox_MouseClick);
            this.landscapeNameTextBox.TextChanged += new System.EventHandler(this.landscapeNameTextBox_TextChanged);
            // 
            // landscapeComboBox
            // 
            this.landscapeComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.landscapeComboBox.FormattingEnabled = true;
            this.landscapeComboBox.Location = new System.Drawing.Point(825, 77);
            this.landscapeComboBox.Name = "landscapeComboBox";
            this.landscapeComboBox.Size = new System.Drawing.Size(160, 24);
            this.landscapeComboBox.TabIndex = 36;
            this.landscapeComboBox.Text = "(Select an option)";
            this.landscapeComboBox.Visible = false;
            this.landscapeComboBox.SelectedIndexChanged += new System.EventHandler(this.landscapeComboBox_SelectedIndexChanged);
            // 
            // addLandscapeButton
            // 
            this.addLandscapeButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addLandscapeButton.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLandscapeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addLandscapeButton.Location = new System.Drawing.Point(824, 16);
            this.addLandscapeButton.Name = "addLandscapeButton";
            this.addLandscapeButton.Size = new System.Drawing.Size(161, 38);
            this.addLandscapeButton.TabIndex = 35;
            this.addLandscapeButton.Text = "Add Landscape";
            this.addLandscapeButton.UseVisualStyleBackColor = false;
            this.addLandscapeButton.Visible = false;
            this.addLandscapeButton.Click += new System.EventHandler(this.addLandscapeButton_Click);
            // 
            // eventDescriptionLabel
            // 
            this.eventDescriptionLabel.AutoSize = true;
            this.eventDescriptionLabel.Location = new System.Drawing.Point(469, 148);
            this.eventDescriptionLabel.Name = "eventDescriptionLabel";
            this.eventDescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.eventDescriptionLabel.TabIndex = 47;
            this.eventDescriptionLabel.Text = "Description";
            this.eventDescriptionLabel.Visible = false;
            // 
            // eventDatePicker
            // 
            this.eventDatePicker.Location = new System.Drawing.Point(471, 212);
            this.eventDatePicker.Name = "eventDatePicker";
            this.eventDatePicker.Size = new System.Drawing.Size(161, 22);
            this.eventDatePicker.TabIndex = 48;
            this.eventDatePicker.Visible = false;
            this.eventDatePicker.ValueChanged += new System.EventHandler(this.eventDatePicker_ValueChanged);
            // 
            // eventDateLabel
            // 
            this.eventDateLabel.AutoSize = true;
            this.eventDateLabel.Location = new System.Drawing.Point(469, 192);
            this.eventDateLabel.Name = "eventDateLabel";
            this.eventDateLabel.Size = new System.Drawing.Size(38, 17);
            this.eventDateLabel.TabIndex = 49;
            this.eventDateLabel.Text = "Date";
            this.eventDateLabel.Visible = false;
            // 
            // selectAnOptionEventLabel
            // 
            this.selectAnOptionEventLabel.AutoSize = true;
            this.selectAnOptionEventLabel.Location = new System.Drawing.Point(469, 55);
            this.selectAnOptionEventLabel.Name = "selectAnOptionEventLabel";
            this.selectAnOptionEventLabel.Size = new System.Drawing.Size(110, 17);
            this.selectAnOptionEventLabel.TabIndex = 51;
            this.selectAnOptionEventLabel.Text = "Select an option";
            this.selectAnOptionEventLabel.Visible = false;
            // 
            // eventComboBox
            // 
            this.eventComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.eventComboBox.FormattingEnabled = true;
            this.eventComboBox.ItemHeight = 16;
            this.eventComboBox.Location = new System.Drawing.Point(472, 77);
            this.eventComboBox.Name = "eventComboBox";
            this.eventComboBox.Size = new System.Drawing.Size(160, 24);
            this.eventComboBox.TabIndex = 50;
            this.eventComboBox.Text = "(Select an option)";
            this.eventComboBox.Visible = false;
            this.eventComboBox.SelectedIndexChanged += new System.EventHandler(this.eventComboBox_SelectedIndexChanged);
            // 
            // placeDescriptionTextBox
            // 
            this.placeDescriptionTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.placeDescriptionTextBox.Location = new System.Drawing.Point(648, 170);
            this.placeDescriptionTextBox.Name = "placeDescriptionTextBox";
            this.placeDescriptionTextBox.Size = new System.Drawing.Size(160, 22);
            this.placeDescriptionTextBox.TabIndex = 52;
            this.placeDescriptionTextBox.Text = "Example: Beautiful place";
            this.placeDescriptionTextBox.Visible = false;
            this.placeDescriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.placeDescriptionTextBox_MouseClick);
            this.placeDescriptionTextBox.TextChanged += new System.EventHandler(this.placeNameTextBox_TextChanged);
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Location = new System.Drawing.Point(646, 104);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(45, 17);
            this.placeNameLabel.TabIndex = 53;
            this.placeNameLabel.Text = "Name";
            this.placeNameLabel.Visible = false;
            // 
            // placeDescriptionLabel
            // 
            this.placeDescriptionLabel.AutoSize = true;
            this.placeDescriptionLabel.Location = new System.Drawing.Point(646, 150);
            this.placeDescriptionLabel.Name = "placeDescriptionLabel";
            this.placeDescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.placeDescriptionLabel.TabIndex = 54;
            this.placeDescriptionLabel.Text = "Description";
            this.placeDescriptionLabel.Visible = false;
            // 
            // placeAddressLabel
            // 
            this.placeAddressLabel.AutoSize = true;
            this.placeAddressLabel.Location = new System.Drawing.Point(646, 194);
            this.placeAddressLabel.Name = "placeAddressLabel";
            this.placeAddressLabel.Size = new System.Drawing.Size(60, 17);
            this.placeAddressLabel.TabIndex = 55;
            this.placeAddressLabel.Text = "Address";
            this.placeAddressLabel.Visible = false;
            // 
            // landscapeNameLabel
            // 
            this.landscapeNameLabel.AutoSize = true;
            this.landscapeNameLabel.Location = new System.Drawing.Point(822, 104);
            this.landscapeNameLabel.Name = "landscapeNameLabel";
            this.landscapeNameLabel.Size = new System.Drawing.Size(45, 17);
            this.landscapeNameLabel.TabIndex = 56;
            this.landscapeNameLabel.Text = "Name";
            this.landscapeNameLabel.Visible = false;
            // 
            // landscapeDescripitonLabel
            // 
            this.landscapeDescripitonLabel.AutoSize = true;
            this.landscapeDescripitonLabel.Location = new System.Drawing.Point(822, 150);
            this.landscapeDescripitonLabel.Name = "landscapeDescripitonLabel";
            this.landscapeDescripitonLabel.Size = new System.Drawing.Size(79, 17);
            this.landscapeDescripitonLabel.TabIndex = 57;
            this.landscapeDescripitonLabel.Text = "Description";
            this.landscapeDescripitonLabel.Visible = false;
            // 
            // initialPictureBox
            // 
            this.initialPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("initialPictureBox.ErrorImage")));
            this.initialPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("initialPictureBox.InitialImage")));
            this.initialPictureBox.Location = new System.Drawing.Point(415, 505);
            this.initialPictureBox.Name = "initialPictureBox";
            this.initialPictureBox.Size = new System.Drawing.Size(248, 45);
            this.initialPictureBox.TabIndex = 58;
            this.initialPictureBox.TabStop = false;
            this.initialPictureBox.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(33, 55);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(224, 221);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // savePhotoButton
            // 
            this.savePhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.savePhotoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savePhotoButton.Location = new System.Drawing.Point(28, 526);
            this.savePhotoButton.Name = "savePhotoButton";
            this.savePhotoButton.Size = new System.Drawing.Size(218, 32);
            this.savePhotoButton.TabIndex = 59;
            this.savePhotoButton.Text = "Save photo";
            this.savePhotoButton.UseVisualStyleBackColor = false;
            this.savePhotoButton.Visible = false;
            this.savePhotoButton.Click += new System.EventHandler(this.savePhotoButton_Click);
            // 
            // InitialSearchButton
            // 
            this.InitialSearchButton.Location = new System.Drawing.Point(698, 567);
            this.InitialSearchButton.Name = "InitialSearchButton";
            this.InitialSearchButton.Size = new System.Drawing.Size(287, 70);
            this.InitialSearchButton.TabIndex = 60;
            this.InitialSearchButton.Text = "Search exisiting photos";
            this.InitialSearchButton.UseVisualStyleBackColor = true;
            this.InitialSearchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(698, 528);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(179, 22);
            this.searchTextBox.TabIndex = 61;
            this.searchTextBox.Text = "Example: John";
            this.searchTextBox.Visible = false;
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(889, 528);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 24);
            this.searchButton.TabIndex = 62;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Visible = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(28, 600);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(218, 37);
            this.backButton.TabIndex = 63;
            this.backButton.Text = "Back to main menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(28, 562);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(218, 32);
            this.deleteButton.TabIndex = 64;
            this.deleteButton.Text = "Delete photo";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // noResultsfooundLabel
            // 
            this.noResultsfooundLabel.AutoSize = true;
            this.noResultsfooundLabel.Location = new System.Drawing.Point(694, 499);
            this.noResultsfooundLabel.Name = "noResultsfooundLabel";
            this.noResultsfooundLabel.Size = new System.Drawing.Size(112, 17);
            this.noResultsfooundLabel.TabIndex = 65;
            this.noResultsfooundLabel.Text = "No results found";
            this.noResultsfooundLabel.Visible = false;
            // 
            // MyPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 658);
            this.Controls.Add(this.noResultsfooundLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.InitialSearchButton);
            this.Controls.Add(this.savePhotoButton);
            this.Controls.Add(this.initialPictureBox);
            this.Controls.Add(this.landscapeDescripitonLabel);
            this.Controls.Add(this.landscapeNameLabel);
            this.Controls.Add(this.placeAddressLabel);
            this.Controls.Add(this.placeDescriptionLabel);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeDescriptionTextBox);
            this.Controls.Add(this.selectAnOptionEventLabel);
            this.Controls.Add(this.eventComboBox);
            this.Controls.Add(this.eventDateLabel);
            this.Controls.Add(this.eventDatePicker);
            this.Controls.Add(this.eventDescriptionLabel);
            this.Controls.Add(this.saveLandscapeButton);
            this.Controls.Add(this.selectAnOptionLandscapeLabel);
            this.Controls.Add(this.landscapeDescriptionTextBox);
            this.Controls.Add(this.landscapeNameTextBox);
            this.Controls.Add(this.landscapeComboBox);
            this.Controls.Add(this.addLandscapeButton);
            this.Controls.Add(this.savePlaceButton);
            this.Controls.Add(this.selectAnOptionPlaceLabel);
            this.Controls.Add(this.placeAddressTextBox);
            this.Controls.Add(this.placeNameTextBox);
            this.Controls.Add(this.placeComboBox);
            this.Controls.Add(this.addPlaceButton);
            this.Controls.Add(this.saveEventButton);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.eventDescriptionTextBox);
            this.Controls.Add(this.eventNameTextBox);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.savePersonButton);
            this.Controls.Add(this.placesLabel);
            this.Controls.Add(this.landscapesLabel);
            this.Controls.Add(this.eventsLabel);
            this.Controls.Add(this.personsLabel);
            this.Controls.Add(this.selectAnOptionPersonLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.personComboBox);
            this.Controls.Add(this.addPerson);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.nextPictureButton);
            this.Controls.Add(this.prevPictureButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.creationDateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.initialBrowseButton);
            this.Name = "MyPhotos";
            this.Text = "My Photos";
            this.Load += new System.EventHandler(this.MyPhotos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button prevPictureButton;
        private System.Windows.Forms.Button nextPictureButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button addPerson;
        private System.Windows.Forms.ComboBox personComboBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label selectAnOptionPersonLabel;
        private System.Windows.Forms.Button initialBrowseButton;
        private System.Windows.Forms.Label personsLabel;
        private System.Windows.Forms.Label eventsLabel;
        private System.Windows.Forms.Label landscapesLabel;
        private System.Windows.Forms.Label placesLabel;
        private System.Windows.Forms.Button savePersonButton;
        private System.Windows.Forms.Button saveEventButton;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.TextBox eventDescriptionTextBox;
        private System.Windows.Forms.TextBox eventNameTextBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.Button savePlaceButton;
        private System.Windows.Forms.Label selectAnOptionPlaceLabel;
        private System.Windows.Forms.TextBox placeAddressTextBox;
        private System.Windows.Forms.TextBox placeNameTextBox;
        private System.Windows.Forms.ComboBox placeComboBox;
        private System.Windows.Forms.Button addPlaceButton;
        private System.Windows.Forms.Button saveLandscapeButton;
        private System.Windows.Forms.Label selectAnOptionLandscapeLabel;
        private System.Windows.Forms.TextBox landscapeDescriptionTextBox;
        private System.Windows.Forms.TextBox landscapeNameTextBox;
        private System.Windows.Forms.ComboBox landscapeComboBox;
        private System.Windows.Forms.Button addLandscapeButton;
        private System.Windows.Forms.Label eventDescriptionLabel;
        private System.Windows.Forms.DateTimePicker eventDatePicker;
        private System.Windows.Forms.Label eventDateLabel;
        private System.Windows.Forms.Label selectAnOptionEventLabel;
        private System.Windows.Forms.ComboBox eventComboBox;
        private System.Windows.Forms.TextBox placeDescriptionTextBox;
        private System.Windows.Forms.Label placeNameLabel;
        private System.Windows.Forms.Label placeDescriptionLabel;
        private System.Windows.Forms.Label placeAddressLabel;
        private System.Windows.Forms.Label landscapeNameLabel;
        private System.Windows.Forms.Label landscapeDescripitonLabel;
        private System.Windows.Forms.PictureBox initialPictureBox;
        private System.Windows.Forms.Button savePhotoButton;
        private System.Windows.Forms.Button InitialSearchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label noResultsfooundLabel;
    }
}

