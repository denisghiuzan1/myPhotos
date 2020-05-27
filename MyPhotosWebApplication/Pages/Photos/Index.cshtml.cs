using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosServiceReference;
using MyPhotosWebApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApplication.Pages.Photos
{
    public class IndexModel : PageModel
    {
        private readonly PhotoControllerClient photoControllerClient;
        public List<PhotoDTO> Photos { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public int SearchResult { get; set; }

        public IndexModel()
        {
            this.photoControllerClient = new PhotoControllerClient();
            this.Photos = new List<PhotoDTO>();
        }

        public async Task OnGetAsync()
        {
            var photos = await photoControllerClient.GetAllPhotosAsync();

            if (!string.IsNullOrEmpty(SearchString))
            {
                photos = await photoControllerClient.SearchPhotoByTextAsync(SearchString);
                SearchResult = photos.Length;
            }

            foreach (var photo in photos.ToList().OrderBy(x=>x.Name))
            {
                var photoDTO = new PhotoDTO
                {
                    Id = photo.Id,
                    CreationDate = photo.CreationDate,
                    Name = photo.Name,
                    Path = photo.Path,
                    IsDeleted = photo.IsDeleted.ToString()
                };

                foreach (var ev in photo.Events.ToList().OrderBy(x=>x.Name))
                {
                    photoDTO.Events.Add(new EventDTO
                    {
                        Id = ev.Id,
                        Date = ev.Date,
                        Description = ev.Description,
                        Name = ev.Name
                    });
                }

                foreach (var person in photo.Persons.ToList().OrderBy(x => x.FirstName))
                {
                    photoDTO.Persons.Add(new PersonDTO
                    {
                        Id = person.Id,
                        FirstName = person.FirstName,
                        LastName = person.LastName
                    });
                }

                foreach (var place in photo.Places.ToList().OrderBy(x => x.Name))
                {
                    photoDTO.Places.Add(new PlaceDTO
                    {
                        Id = place.Id,
                        Description = place.Description,
                        Name = place.Name,
                        Address = place.Address
                    });
                }
                foreach (var landscape in photo.Landscapes.ToList().OrderBy(x => x.Name))
                {
                    photoDTO.Landscapes.Add(new LandscapeDTO
                    {
                        Id = landscape.Id,
                        Description = landscape.Description,
                        Name = landscape.Name
                    });
                }
                Photos.Add(photoDTO);
            }
        }

    }
}