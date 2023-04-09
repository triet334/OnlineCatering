using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
        //    Wishlists = new HashSet<Wishlist>();
        }

        public int Cusid { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Userpass { get; set; }
        [Required]
        [StringLength(maximumLength:15)]
        public string Cusphone { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Cusaddress { get; set; }
        [Required]
        public string Cusfullname { get; set; }
        [Required]
        public bool Cusstatus { get; set; }
        [Required]
        public bool Admin { get; set; }
        [Required]
        public string Cusemail { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }
        //public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
