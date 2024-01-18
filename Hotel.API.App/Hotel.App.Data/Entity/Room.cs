using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.App.Data.Entity
{
    public class Room
    {
        public int RoomId { get; set; }
        public OtherType OtherType { get; set; }
        public RoomStutas RoomStutas { get; set; }
        public RoomType RoomType { get; set; }
    }
}
