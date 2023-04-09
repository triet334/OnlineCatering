using System;
using System.Collections.Generic;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class Wishlist
    {
        public int Wishlistid { get; set; }
        public int Caterid { get; set; }
        public int Cusid { get; set; }


        //public virtual Customer Cus { get; set; }
        //public virtual Caterer WishlistNavigation { get; set; }
    }
}
