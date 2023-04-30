using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentRepository.Interfaces
{
    public interface IRepository<T>
    { 
        Task<List<T>> GetAllAsync();
    }
}
