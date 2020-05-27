using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApplication.Models
{
    public class PhotoDTO
    {
        public PhotoDTO()
        {
            this.Persons = new HashSet<PersonDTO>();
            this.Landscapes = new HashSet<LandscapeDTO>();
            this.Events = new HashSet<EventDTO>();
            this.Places = new HashSet<PlaceDTO>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string IsDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonDTO> Persons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LandscapeDTO> Landscapes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventDTO> Events { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlaceDTO> Places { get; set; }
    }
}
