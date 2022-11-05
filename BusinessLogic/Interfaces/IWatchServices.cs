using BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IWatchServices
    {
        IEnumerable<WatchDto> GetAll();
        WatchDto? GetById(int id);
        void Create(WatchDto laptop);
        void Edit(WatchDto laptop);
        void Delete(int id);
    }
}
