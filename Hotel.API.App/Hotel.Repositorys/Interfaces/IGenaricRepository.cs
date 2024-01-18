using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Repositorys.Interfaces
{
    public interface IGenaricRepository<T> where T : class
    {
        public Task AddRangeAsync(IEnumerable<T> T);
        public Task<T> AddAsync(T T);
        public Task DeleteAsync(int id);
        public Task<IEnumerable<T>> GetFullAsync();
        public Task<T> GetAsync(int id);
        public Task UpdateAsync(T T);
    }
}
