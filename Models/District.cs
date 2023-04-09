using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Pro3_Sem3.Models
{
    [Table("District")]
    public class District
    {
        public District()
        {
            Cater = new HashSet<Caterer>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DistrictId { get; set; }

        [Required]
        public string DistrictName { get; set; }
      
        public virtual ICollection<Caterer> Cater { get; set; }

    }
}
