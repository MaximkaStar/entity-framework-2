using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EntityFramework2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (UserContext db = new UserContext())
            {
                var products = db.products;
                foreach(Product m in products)
                {
                    WriteLine("{0}.{1} - {2}", m.Id, m.Name, m.Price, m.productionDate);
                }
            }
        }
    }
}
