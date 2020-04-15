using System.Collections.Generic;
using System.ServiceModel;
using MyPhotos.Model;

namespace MyPhotosObjectWCF
{
    [ServiceContract]
    public interface IPhotoController
    {
        [OperationContract]
        void AddOrUpdatePhoto(Photo photoToAddOrUpdate);

        [OperationContract]
        List<Photo> SearchPhotoByText(string text);

        [OperationContract]
        void DeletePhoto(Photo photoToDelete);

        [OperationContract]
        List<Photo> GetAllPhotos();

        [OperationContract]
        List<Person> GetAllPersons();

        [OperationContract]
        List<Event> GetAllEvents();

        [OperationContract]
        List<Landscape> GetAllLandscapes();

        [OperationContract]
        List<Place> GetAllPlaces();
    }
}
