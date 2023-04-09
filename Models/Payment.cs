using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class Payment
    {
        public Payment()
        {
            PaymentDetails = new HashSet<PaymentDetail>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Paymentid { get; set; }
        public DateTime OrderDate { get; set; }
        public int Cusid { get; set; }
        public bool Status { get; set; }
        public decimal Amount { get; set; }
        public DateTime DeliveryDate { get; set; }           

        public int Caterid { get; set; }
        [Required]
        [StringLength(maximumLength:70)]
        public string Orderaddress { get; set; }

        //public int Detailsid { get; set; }
        public virtual Caterer Cater { get; set; }
        public virtual Customer Cus { get; set; }
        public virtual ICollection<PaymentDetail> PaymentDetails { get; set; }
    }
}
