using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class Food
    {
        public Food()
        {
            PaymentDetails = new HashSet<PaymentDetail>();
        }

        public int Foodid { get; set; }
        public string Foodname { get; set; }
        public string? Foodimage { get; set; }
        public bool Foodstatus { get; set; }
        public decimal Foodprice { get; set; }
        public int Caterid { get; set; }
        public string Fooddescription { get; set; }

        [NotMapped]
        [DisplayName("Upload Photo")]
        public IFormFile PhotoUpload { get; set; }

        public virtual Caterer Cater { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
