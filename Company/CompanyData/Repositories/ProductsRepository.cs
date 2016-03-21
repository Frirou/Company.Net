using CompanyData.Infrastructure;
using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Repositories
{
    public class ProductsRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductsRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IProductRepository : IRepository<Product> { }
}
