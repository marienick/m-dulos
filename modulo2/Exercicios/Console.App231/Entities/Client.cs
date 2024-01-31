using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp231.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }

        public Client(string name, string email, string dateBirth)
        {
            Name = name;
            Email = email;
            DateBirth = DateTime.Parse(dateBirth);
        }
    }
}
