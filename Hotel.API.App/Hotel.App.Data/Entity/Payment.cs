using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.App.Data.Entity
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int ResvationId { get; set; }
        public Resvation Resvation { get; set; }
        public decimal Amount { get; set; }
    }
}
