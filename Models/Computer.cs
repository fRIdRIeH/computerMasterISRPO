using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaster.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Hdd { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }

        public Computer() { }

        public Computer(string model, string processor, string ram, string hdd, decimal price, int amount, string description) 
        {
            Model = model;
            Processor = processor;
            Ram = ram;
            Hdd = hdd;
            Price = price;
            Amount = amount;
            Description = description;
        }

        public Computer(int id, string model, string processor, string ram, string hdd, decimal price, int amount, string description)
        {
            Id = id;
            Model = model;
            Processor = processor;
            Ram = ram;
            Hdd = hdd;
            Price = price;
            Amount = amount;
            Description = description;
        }
    }
}
