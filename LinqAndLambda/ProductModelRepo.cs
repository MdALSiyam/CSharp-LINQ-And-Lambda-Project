using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    public class ProductModelRepo
    {
        List<ProductModel> modelList;

        public ProductModelRepo()
        {
            modelList = new List<ProductModel>()
            {
                new ProductModel {ProductModelID = 1, Name = "Classic Vest"},
                new ProductModel {ProductModelID = 2, Name = "Cycling Cap"},
                new ProductModel {ProductModelID = 3, Name = "Full-Finger Gloves"},
                new ProductModel {ProductModelID = 4, Name = "Half-Finger Gloves"},
                new ProductModel {ProductModelID = 5, Name = "HL Mountain Frame"},
                new ProductModel {ProductModelID = 6, Name = "HL Road Frame"},
                new ProductModel {ProductModelID = 7, Name = "HL Touring Frame"},
                new ProductModel {ProductModelID = 8, Name = "LL Mountain Frame"},
                new ProductModel {ProductModelID = 9, Name = "LL Road Frame"},
                new ProductModel {ProductModelID = 10, Name = "LL Touring Frame"},
                new ProductModel {ProductModelID = 11, Name = "Long-Sleeve Logo Jersey"},
                new ProductModel {ProductModelID = 12, Name = "Men's Bib-Shorts"},
                new ProductModel {ProductModelID = 13, Name = "Men's Sports Shorts"},
                new ProductModel {ProductModelID = 14, Name = "ML Mountain Frame"},
                new ProductModel {ProductModelID = 15, Name = "ML Mountain Frame-W"},
                new ProductModel {ProductModelID = 16, Name = "ML Road Frame"},
                new ProductModel {ProductModelID = 17, Name = "ML Road Frame-W"},
                new ProductModel {ProductModelID = 18, Name = "Mountain Bike Socks"},
                new ProductModel {ProductModelID = 19, Name = "Mountain-100"}
            };
        }

        public IEnumerable<ProductModel> GetAllModels()
        {
            return modelList;
        }
    }
}
