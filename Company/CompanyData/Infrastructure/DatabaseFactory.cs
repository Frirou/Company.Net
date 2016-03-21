
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyData.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private CompanyDBContext dataContext;
        public CompanyDBContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new CompanyDBContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }
}
