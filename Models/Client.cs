using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaster.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronimyc { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }

        public Client() { }

        public Client(string surname, string name, string patronimyc, string email, string telephone, string address)
        {
            Surname = surname;
            Name = name;
            Patronimyc = patronimyc;
            Email = email;
            Telephone = telephone;
            Address = address;
        }

        public Client(int id, string surname, string name, string patronimyc, string email, string telephone, string address)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Patronimyc = patronimyc;
            Email = email;
            Telephone = telephone;
            Address = address;
        }
    }
}
