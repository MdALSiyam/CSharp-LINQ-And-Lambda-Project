using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            ProductRepo repo1 = new ProductRepo();
            var productList = repo1.GetAllProducts();

            ProductCategoryRepo repo2 = new ProductCategoryRepo();
            var categoryList = repo2.GetAllCategories();

            ProductModelRepo repo3 = new ProductModelRepo();
            var modelList = repo3.GetAllModels();

            Console.WriteLine("Lambda Test");
            Console.WriteLine("===========");

            var lambdaList = productList.Join(categoryList, p => p.ProductCategoryID, c => c.ProductCategoryID, (p, c) => new { p, c }).Join(modelList, pc => pc.p.ProductModelID, m => m.ProductModelID, (pc, m) => new { pc, m }).Select(n => new
            {
                ProductId = n.pc.p.ProductID,
                ProductName = n.pc.p.Name,
                ProductNumber = n.pc.p.ProductNumber,
                Color = n.pc.p.Color,
                StandardCost = n.pc.p.StandardCost,
                ListPrice = n.pc.p.ListPrice,
                Size = n.pc.p.Size,
                Weight = n.pc.p.Weight,
                CategoryName = n.pc.c.Name,
                ModelName = n.m.Name
            });

            foreach (var item in lambdaList)
            {
                Console.WriteLine();
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductNumber);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.StandardCost);
                Console.WriteLine(item.ListPrice);
                Console.WriteLine(item.Size);
                Console.WriteLine(item.Weight);
                Console.WriteLine(item.CategoryName);
                Console.WriteLine(item.ModelName);
                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------------- ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Linq Test");
            Console.WriteLine("=========");

            var List = from p in productList
                       join c in categoryList
                       on p.ProductCategoryID equals c.ProductCategoryID
                       join m in modelList
                       on p.ProductModelID equals m.ProductModelID
                       select new
                       {
                           ProductId = p.ProductID,
                           ProductName = p.Name,
                           ProductNumber = p.ProductNumber,
                           Color = p.Color,
                           StandardCost = p.StandardCost,
                           ListPrice = p.ListPrice,
                           Size = p.Size,
                           Weight = p.Weight,
                           CategoryName = c.Name,
                           ModelName = m.Name
                       };

            foreach (var item in List)
            {
                Console.WriteLine();
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.ProductNumber);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.StandardCost);
                Console.WriteLine(item.ListPrice);
                Console.WriteLine(item.Size);
                Console.WriteLine(item.Weight);
                Console.WriteLine(item.CategoryName);
                Console.WriteLine(item.ModelName);
                Console.WriteLine();
            }
        }
    }
}
