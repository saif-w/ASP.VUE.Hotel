using Hotel.App.Data.Entity;
using Hotel.Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorys.Repository
{
    public class GuestRepostiory : GenaricRepository<Guest>, IGuestRepostiory
    {
        public GuestRepostiory(HotelDbContext hotelDbContext) : base(hotelDbContext)
        {
        }
    }
}
