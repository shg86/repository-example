using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(NorthwindEntities context)
            : base(context)
        {

        }

        public IEnumerable<Customer> GetRecentCustomers(int count)
        {
            return NorthwindEntities.Customers.OrderBy(c => c.Orders).Take(count).ToList();
        }

        public NorthwindEntities NorthwindEntities
        {
            get { return Context as NorthwindEntities;  }
        }
    }
}
