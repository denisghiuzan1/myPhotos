using System.Collections.Generic;
using System.Linq;

namespace MyPhotos.Model
{
    public class APIController
    {
        private readonly Dictionary<int, byte[]> files = new Dictionary<int, byte[]>();
        private readonly MyPhotosEntities context = new MyPhotosEntities();
        private readonly List<Event> events = new List<Event>();
        private readonly List<Landscape> landscapes = new List<Landscape>();
        private readonly List<Person> persons = new List<Person>();
        private List<Photo> photos = new List<Photo>();
        private readonly List<Place> places = new List<Place>();
        
        public void AddOrUpdatePhoto(Photo photoToAddOrUpdate)
        {
            var update = this.UpdatePhoto(photoToAddOrUpdate);
            
            if (!update)
            {
                context.Photos.Add(photoToAddOrUpdate);
                foreach (var person in photoToAddOrUpdate.Persons)
                    if (persons.Contains(person))
                    {
                        person.Photos.Add(photoToAddOrUpdate);
                    }
                    else
                    {
                        person.Photos.Add(photoToAddOrUpdate);
                        context.Persons.Add(person);
                    }

                foreach (var ev in photoToAddOrUpdate.Events)
                    if (events.Contains(ev))
                    {
                        ev.Photos.Add(photoToAddOrUpdate);
                    }
                    else
                    {
                        ev.Photos.Add(photoToAddOrUpdate);
                        context.Events.Add(ev);
                    }

                foreach (var place in photoToAddOrUpdate.Places)
                    if (places.Contains(place))
                    {
                        place.Photos.Add(photoToAddOrUpdate);
                    }
                    else
                    {
                        place.Photos.Add(photoToAddOrUpdate);
                        context.Places.Add(place);
                    }

                foreach (var landscape in photoToAddOrUpdate.Landscapes)
                    if (landscapes.Contains(landscape))
                    {
                        landscape.Photos.Add(photoToAddOrUpdate);
                    }
                    else
                    {
                        landscape.Photos.Add(photoToAddOrUpdate);
                        context.Landscapes.Add(landscape);
                    }

            }
            
            context.SaveChanges();
        }
        private bool UpdatePhoto(Photo photoToUpdate)
        {
            var update = false;
            GetAllPhotos();
            foreach (var photo in this.photos)
            {
                if (photo.Name.Equals(photoToUpdate.Name)
                    && photo.Path.Equals(photoToUpdate.Path))
                {
                    foreach (var ev in photoToUpdate.Events.ToList()) photo.Events.Add(ev);
                    foreach (var place in photoToUpdate.Places.ToList()) photo.Places.Add(place);
                    foreach (var person in photoToUpdate.Persons.ToList()) photo.Persons.Add(person);
                    foreach (var landscape in photoToUpdate.Landscapes.ToList()) photo.Landscapes.Add(landscape);
                    update = true;
                }
            }

            return update;
        }

        public List<Photo> SearchPhotoByText(string text)
        {
            var searchResult = new List<Photo>();

            photos = context.Photos.ToList();
            foreach (var photo in photos)
            {
                if (photo.IsDeleted==false)
                {
                    var x = photo.CreationDate.ToString();
                    if (photo.Name.Contains(text)
                    ||photo.Path.Contains(text)
                    ||photo.CreationDate.ToString().Contains(text))
                    {
                        searchResult.Add(photo);
                    }
                    var photoPersons = photo.Persons;
                    foreach (var person in photoPersons)
                        if (person.LastName.Contains(text)
                            || person.FirstName.Contains(text)
                            && !searchResult.Contains(photo))
                            searchResult.Add(photo);

                    var photoEvents = photo.Events;
                    foreach (var ev in photoEvents)
                        if (ev.Name.Contains(text)
                            || ev.Description.Contains(text)
                            && !searchResult.Contains(photo))
                            searchResult.Add(photo);

                    var photoPlaces = photo.Places;
                    foreach (var place in photoPlaces)
                        if (place.Name.Contains(text)
                            || place.Description.Contains(text)
                            && !searchResult.Contains(photo))
                            searchResult.Add(photo);

                    var photoLandscapes = photo.Landscapes;
                    foreach (var landscape in photoLandscapes)
                        if (landscape.Name.Contains(text)
                            || landscape.Description.Contains(text)
                            && !searchResult.Contains(photo))
                            searchResult.Add(photo);
                }
                
            }

            return searchResult;
        }
        
        public List<Person> GetAllPersons()
        {
            foreach (var person in context.Persons) persons.Add(person);

            return persons;
        }
        
        public List<Event> GetAllEvents()
        {
            foreach (var ev in context.Events) events.Add(ev);

            return events;
        }

        public List<Landscape> GetAllLandscapes()
        {
            foreach (var landscape in context.Landscapes) landscapes.Add(landscape);

            return landscapes;
        }

        public List<Place> GetAllPlaces()
        {
            foreach (var place in context.Places) places.Add(place);

            return places;
        }

        public List<Photo> GetAllPhotos()
        {
            foreach (var photo in context.Photos)
                if (photo.IsDeleted.Equals(false))
                {
                    photos.Add(photo);
                }

            return photos;
        }

        public void DeletePhoto(Photo photoToDelete)
        {
            GetAllPhotos();
            foreach (var photo in photos)
                if (photo.Name.Equals(photoToDelete.Name)
                && photo.Path.Equals(photoToDelete.Path))
                    photo.IsDeleted = true;
            context.SaveChanges();
        }
    }
}