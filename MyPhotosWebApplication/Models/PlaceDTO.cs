using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApplication.Models
{
    public class PlaceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhotoDTO> Photos { get; set; }
    }
}
