using AppService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppService.Domain.Repositories
{
    public interface IBaseRepository<T> where T: BaseEntity
    {
        Task<T> GetItemAsync(Guid id);
        void AddItemAsync(T item);
        Task<bool> DeleteItemAsync(Guid id);
        Task<T> UdateItemAsync(Guid id, T item);
        Task<IEnumerable<T>> GetAllItemsAsync();
    }
}
