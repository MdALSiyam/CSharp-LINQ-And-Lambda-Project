using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    public class ProductCategoryRepo
    {
        List<ProductCategory> categoryList;

        public ProductCategoryRepo()
        {
            categoryList = new List<ProductCategory>()
            {
                new ProductCategory{ ProductCategoryID = 1, Name = "Bikes"},
                new ProductCategory{ ProductCategoryID = 2, Name = "Components"},
                new ProductCategory{ ProductCategoryID = 3, Name = "Clothing"},
                new ProductCategory{ ProductCategoryID = 4, Name = "Accessories"},
                new ProductCategory{ ProductCategoryID = 5, Name = "Mountain Bikes"},
                new ProductCategory{ ProductCategoryID = 6, Name = "Road Bikes"},
                new ProductCategory{ ProductCategoryID = 7, Name = "Touring Bikes"},
                new ProductCategory{ ProductCategoryID = 8, Name = "Handlebars"},
                new ProductCategory{ ProductCategoryID = 9, Name = "Bottom Brackets"},
                new ProductCategory{ ProductCategoryID = 10, Name = "Brakes"},
                new ProductCategory{ ProductCategoryID = 11, Name = "Chains"},
                new ProductCategory{ ProductCategoryID = 12, Name = "Cranksets"},
                new ProductCategory{ ProductCategoryID = 13, Name = "Derailleurs"},
                new ProductCategory{ ProductCategoryID = 14, Name = "Forks"},
                new ProductCategory{ ProductCategoryID = 15, Name = "Headsets"},
                new ProductCategory{ ProductCategoryID = 16, Name = "Mountain Frames"},
                new ProductCategory{ ProductCategoryID = 17, Name = "Pedals"},
                new ProductCategory{ ProductCategoryID = 18, Name = "Road Frames"},
                new ProductCategory{ ProductCategoryID = 19, Name = "Saddles"},
                new ProductCategory{ ProductCategoryID = 20, Name = "Touring Frames"},
                new ProductCategory{ ProductCategoryID = 21, Name = "Wheels"},
                new ProductCategory{ ProductCategoryID = 22, Name = "Bib-Shorts"},
                new ProductCategory{ ProductCategoryID = 23, Name = "Caps"},
                new ProductCategory{ ProductCategoryID = 24, Name = "Gloves"},
                new ProductCategory{ ProductCategoryID = 25, Name = "Jerseys"},
                new ProductCategory{ ProductCategoryID = 26, Name = "Shorts"},
                new ProductCategory{ ProductCategoryID = 27, Name = "Socks"},
                new ProductCategory{ ProductCategoryID = 28, Name = "Tights"},
                new ProductCategory{ ProductCategoryID = 29, Name = "Vests"},
                new ProductCategory{ ProductCategoryID = 30, Name = "Bike Racks"},
                new ProductCategory{ ProductCategoryID = 31, Name = "Bike Stands"},
                new ProductCategory{ ProductCategoryID = 32, Name = "Bottles and Cages"},
                new ProductCategory{ ProductCategoryID = 33, Name = "Cleaners"},
                new ProductCategory{ ProductCategoryID = 34, Name = "Fenders"},
                new ProductCategory{ ProductCategoryID = 35, Name = "Helmets"},
                new ProductCategory{ ProductCategoryID = 36, Name = "Hydration Packs"},
                new ProductCategory{ ProductCategoryID = 37, Name = "Lights"},
                new ProductCategory{ ProductCategoryID = 38, Name = "Locks"},
                new ProductCategory{ ProductCategoryID = 39, Name = "Panniers"},
                new ProductCategory{ ProductCategoryID = 40, Name = "Pumps" },
                new ProductCategory{ ProductCategoryID = 41, Name = "Tires and Tubes"}
            };
        }

        public IEnumerable<ProductCategory> GetAllCategories()
        {
            return categoryList;
        }
    }
}
