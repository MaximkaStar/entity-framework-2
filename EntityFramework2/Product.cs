using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EntityFramework2
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ammout { get; set; }
        public int Price { get; set; }
        public DateTime productionDate { get; set; }
    }
}
