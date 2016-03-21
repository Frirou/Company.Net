using CompanyData.Infrastructure;
using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Repositories
{
    public class CategoriesRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoriesRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }
    public interface ICategoryRepository : IRepository<Category> { }
}
