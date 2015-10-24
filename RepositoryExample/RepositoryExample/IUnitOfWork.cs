﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        int Complete();
    }
}
