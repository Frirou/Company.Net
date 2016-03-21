using CompanyData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        ICustomerRepository CustomerRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }
    }
}
