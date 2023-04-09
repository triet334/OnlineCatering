using System;
using System.Collections.Generic;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class PaymentDetail
    {
       
        public int Detailsid { get; set; }
        public int Paymentid { get; set; }
        public int Foodid { get; set; }
        public decimal Quantity { get; set; }

        public decimal Total { set; get; }
       
        public virtual Food Food { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
