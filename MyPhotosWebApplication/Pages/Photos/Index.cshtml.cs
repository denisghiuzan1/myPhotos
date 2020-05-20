using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosServiceReference;

namespace MyPhotosWebApplication.Pages.Photos
{
    public class IndexModel : PageModel
    {
        private PhotoControllerClient photoControllerClient;
        public List<Photo> Photos { get; set; }

        public IndexModel()
        {
            this.photoControllerClient = new PhotoControllerClient();
            this.Photos = new List<Photo>();
        }

        public async Task OnGetAsync()
        {
            var photos = await photoControllerClient.GetAllPhotosAsync();
            foreach (var photo in photos)
            {

                Photos.Add(new Photo
                {
                    Id = photo.Id,
                    CreationDate = photo.CreationDate,
                    Name = photo.Name,
                    Path = photo.Path,
                    IsDeleted = photo.IsDeleted,
                    Events = photo.Events,
                    Landscapes = photo.Landscapes,
                    Persons = photo.Persons,
                    Places = photo.Places
                });
                
            }
        }

    }
}