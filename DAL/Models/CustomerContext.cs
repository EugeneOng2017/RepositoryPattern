using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("name=CustomerContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Customer> Customer { get; set; }
    }
}
