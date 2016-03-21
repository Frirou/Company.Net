using CompanyData.Infrastructure;
using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Repositories
{
    public class CustomersRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomersRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
    public interface ICustomerRepository : IRepository<Customer> { }
}
