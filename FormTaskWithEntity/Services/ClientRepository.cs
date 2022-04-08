using FormTaskWithEntity.Data;
using FormTaskWithEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Services
{
    public class ClientRepository : IRepository
    {
        private readonly ClientDbContext _context;

        public ClientRepository(ClientDbContext context)
        {
            _context = context;
        }

        public void Add(Client item)
        {
            //_context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT ClientDB.Clients ON;");
            _context.Clients.Add(item);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var client = _context.Clients.Where(x => x.ID == id).ToArray();
            if (client != null)
            {
                _context.Clients.Remove(client[0]);
                _context.SaveChanges();
            }
        }

        public Client Get(int id)
        {

            var client = _context.Clients.Where(x => x.ID == id).ToArray() ;
            return client[0];
        }

        public IEnumerable<Client> GetAll()
        {
            return _context.Clients.ToList();
        }

        public void Update(int id,Client item)
        {
            var client=Get(id);
            client.Name = item.Name;
            client.Surname = item.Surname;
            client.Age = item.Age;
            client.Salary = item.Salary;
            client.Adress = item.Adress;
            _context.SaveChanges();
        }
    }
}
