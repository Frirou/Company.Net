using CompanyData.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private CompanyDBContext dataContext;
        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        private ICustomerRepository customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get { return customerRepository = new CustomersRepository(dbFactory); }
        }
        private ICategoryRepository categoryRepository;
        public ICategoryRepository CategoryRepository
        {
            get { return categoryRepository = new CategoriesRepository(dbFactory); }
        }
        private IProductRepository productRepository;
        public IProductRepository ProductRepository
        {
            get { return productRepository = new ProductsRepository(dbFactory); }
        }
        protected CompanyDBContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }
        public void Dispose()
        {
            dbFactory.Dispose();
        }
    }
}
