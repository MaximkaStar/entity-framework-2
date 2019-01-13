using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework2
{
    public class UserContext : DbContext
    {
        public UserContext(): base("ShopDB") { }

        public DbSet<Product> products { get; set; }
    }
}
