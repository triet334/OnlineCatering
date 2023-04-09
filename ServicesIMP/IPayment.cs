using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pro3_Sem3.Models;

namespace Pro3_Sem3.ServicesIMP
{
    public interface IPayment
    {
        public List<Payment> GetAllPayment();

       

    }
}
