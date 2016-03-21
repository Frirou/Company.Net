using System;
namespace CompanyService
{
    public interface ICompanyService
    {
        System.Collections.Generic.List<CompanyDomain.Entities.Category> getCategories();
        System.Collections.Generic.List<CompanyDomain.Entities.Product> getProducts();
    }
}
