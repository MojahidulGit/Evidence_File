using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkQuery
{
    internal class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductModel> Products { get; set; }

        public ProductModel()
        {
            Products = new HashSet<ProductModel>();
        }
        public ProductModel(int productModelID, string name)
        {
            ProductModelID = productModelID;
            Name = name;
        }

    }
}
