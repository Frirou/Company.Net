using CompanyDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CompanyService;
using System.Web.ModelBinding;

namespace CompanyGUI
{
    public partial class Products : System.Web.UI.Page
    {
        CompanyService.CompanyService cs;
        protected void Page_Load(object sender, EventArgs e)
        {
            cs = new CompanyService.CompanyService();
        }

        protected void ObjectDataSource1_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {

        }
        public List<Category> GetCategories([Control]int? MinProductsCount)
        {
            if (MinProductsCount.HasValue)
            {
                return cs.getCategories().Where(c => c.Products.Count >= MinProductsCount).ToList();

            }
            return null;
        }
        public List<Product> getProducts([QueryString]int? id)
        {

            return cs.getProducts().Where(c => c.CategoryId == id).ToList();
        }

    }
}