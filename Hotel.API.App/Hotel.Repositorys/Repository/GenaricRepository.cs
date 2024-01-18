using Hotel.App.Data.Entity;
using Hotel.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorys.Repository
{
    public class GenaricRepository<T>: IGenaricRepository<T> where T:class
    {
        private readonly HotelDbContext context;

        public GenaricRepository(HotelDbContext hotelDbContext)
        {
            context = hotelDbContext;
        }

        public async Task<T> GetAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetFullAsync()
        {

            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T T)
        {
            await context.Set<T>().AddAsync(T);
            await context.SaveChangesAsync();

            return T;
        }

        public async Task AddRangeAsync(IEnumerable<T> T)
        {
            await context.Set<T>().AddRangeAsync(T);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var data = await context.Set<T>().FindAsync(id);

                context.Set<T>().Remove(data);
                await context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task UpdateAsync(T t)
        {

            try
            {
                context.Entry(t).State = EntityState.Modified;

                //context.Set<T>().Update(T);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}
