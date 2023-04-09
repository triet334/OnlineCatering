using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Pro3_Sem3.Models
{
    public partial class Worker
    {
        [Key]
        public int Workerid { get; set; }
        public string Wokername { get; set; }
        public string Workerphone { get; set; }
        public string Workeraddress { get; set; }
        public bool Status { get; set; }
        public decimal Workersalary { get; set; }
        public string Workertype { get; set; }
        public int Caterid { get; set; }

        public virtual Caterer Cater { get; set; }
    }
}
