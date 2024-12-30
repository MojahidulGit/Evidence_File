using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQuery
{
    internal class ProductCategory
    {
        public int ProductCategoryID {  get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductModel> ProductModel { get; set; }

        public ProductCategory()
        {
            ProductModel = new HashSet<ProductModel>();
        }
        public ProductCategory (int productCategoryID, string name): this() 
        {
            ProductCategoryID= productCategoryID;
            Name= name;
        }
    }
}
