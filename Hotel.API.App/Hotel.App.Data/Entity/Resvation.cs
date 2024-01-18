using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.App.Data.Entity
{
    public class Resvation
    {
        public int ResvationId { get; set; }
        public Guest Guest { get; set; }
        public Room Room { get; set; }
        public int GuestId { get; set; }
        public int RoomId { get; set; }
        public DateTime ResvationDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }
    }
}
