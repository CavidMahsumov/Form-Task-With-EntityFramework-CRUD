using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormTaskWithEntity.Entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public double Salary { get; set; }

    }
}
