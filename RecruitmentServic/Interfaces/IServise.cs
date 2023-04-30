using Common.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IService<T>
    {
        Task<List<T>> GetAllAsync();
    }
}