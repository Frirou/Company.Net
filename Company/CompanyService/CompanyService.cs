using CompanyData.Infrastructure;
using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyService
{
    public class CompanyService : ICompanyService
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public CompanyService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }
        public List<Category> getCategories()
        {
            return utOfWork.CategoryRepository.GetAll().ToList();
        }
        public void createCategory(Category c)
        {
            utOfWork.CategoryRepository.Add(c);
            utOfWork.Commit();
        }
        public List<Product> getProducts()
        {

            return utOfWork.ProductRepository.GetAll().ToList();
        }

        public void CreateProducts(Product d)
        {   utOfWork.ProductRepository.Add(d);
            utOfWork.Commit();
        }
    }
}
