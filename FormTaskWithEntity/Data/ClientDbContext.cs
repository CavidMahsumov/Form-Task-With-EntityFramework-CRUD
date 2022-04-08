using FormTaskWithEntity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Data
{
    public class ClientDbContext:DbContext
    {

        public ClientDbContext(DbContextOptions<ClientDbContext> options)
            :base(options)
        {

        }
        public DbSet<Client>Clients { get; set; }
    }
}
