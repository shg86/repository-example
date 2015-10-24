using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindEntities _context;
        public ICustomerRepository Customers { get; set; }

        public UnitOfWork(NorthwindEntities context)
        {
            _context = context;
            Customers = new CustomerRepository(_context);
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
