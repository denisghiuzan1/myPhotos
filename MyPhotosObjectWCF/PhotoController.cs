using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos.Model;


namespace MyPhotosObjectWCF
{
    public class PhotoController : IPhotoController
    {
        private readonly APIController apiController;

        public PhotoController()
        {
            this.apiController = new APIController();
        }

        public void AddOrUpdatePhoto(Photo photoToAddOrUpdate)
        {
            this.apiController.AddOrUpdatePhoto(photoToAddOrUpdate);
        }

        public List<Photo> SearchPhotoByText(string text)
        {
            return this.apiController.SearchPhotoByText(text);
        }

        public void DeletePhoto(Photo photoToDelete)
        {
            this.apiController.DeletePhoto(photoToDelete);
        }

        public List<Photo> GetAllPhotos()
        {
            return this.apiController.GetAllPhotos();
        }

        public List<Person> GetAllPersons()
        {
            return this.apiController.GetAllPersons();
        }

        public List<Event> GetAllEvents()
        {
            return this.apiController.GetAllEvents();
        }

        public List<Landscape> GetAllLandscapes()
        {
            return this.apiController.GetAllLandscapes();
        }

        public List<Place> GetAllPlaces()
        {
            return this.apiController.GetAllPlaces();
        }
    }
}
