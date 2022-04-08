using FormTaskWithEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Services
{
   public interface IRepository
   {
        void Add(Client item);
        void Delete(int id);
        void Update(int id,Client item);
        Client Get(int id);
        IEnumerable<Client> GetAll();
    }
}
