using DAL.Models;
using Repository.Core;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CustomerContext _context;
        private Repository<Customer> customerRepository;

        public UnitOfWork()
        {
            _context = new CustomerContext();
        }

        public Repository<Customer> CustomerRepo
        {
            get
            {
                if (customerRepository == null)
                {
                    customerRepository = new Repository<Customer>(_context);
                }
                return customerRepository;
            }
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
