using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.App.Data.Entity
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<OtherType> OtherType { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Resvation> Resvations { get; set; }
        public DbSet<RoomStutas> RoomStutas { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
    }
}
