using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new NorthwindEntities()))
            {
                // Example 1 : Get single customer
                var customer = unitOfWork.Customers.Get("Wolza");

                // Example 2 : Get specific customers
                var customers = unitOfWork.Customers.GetRecentCustomers(5);

                // Example 3 : Remove customer and complete unit of work
                unitOfWork.Customers.Remove(customer);
                unitOfWork.Complete();
            }
        }
    }
}
