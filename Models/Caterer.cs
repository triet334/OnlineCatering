using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class Caterer
    {
        public Caterer()
        {
            Foods = new HashSet<Food>();
            Payments = new HashSet<Payment>();
            Workers = new HashSet<Worker>();
            Districts = new HashSet<District>();
        }
       
        [Key]
        public int Caterid { get; set; }
        [Required]
        public string Catername { get; set; }
        [Required]
        public string Caterpasss { get; set; }
        [Required]
        public string Caterfullname { get; set; }
        [Required]
        public string Cateraddress { get; set; }
        [Required]
        [StringLength(maximumLength:11)]
        public string Caterphone { get; set; }
        public bool Caterstatus { get; set; }
        public string Cateremail { get; set; }
        public string Photo { get; set; }
        public int DistrictId { get; set; }

        [Required]
        
        public int MaxPeople { get; set; }


        [NotMapped]
        [DisplayName("Upload Photo")]
        public IFormFile PhotoUpload { get; set; }

        //public virtual Wishlist Wishlist { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
        public virtual ICollection<District> Districts { get; set; }
    }
}
