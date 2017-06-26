using DAL.Models;
using Repository.Core;

namespace Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(CustomerContext context)
            : base(context)
        {

        }
    }
}
