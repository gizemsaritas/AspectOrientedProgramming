using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectOrientedProgramming.Business.Abstract;
using AspectOrientedProgramming.Business.Concrete;
using AspectOrientedProgramming.Core.CrossCuttingConcerns.Caching;
using AspectOrientedProgramming.Core.CrossCuttingConcerns.Logging;
using AspectOrientedProgramming.DataAccess.Concrete.EntityFramework;
using AspectOrientedProgramming.DataAccess.Concrete.NHibernate;

namespace AspectOrientedProgramming.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new NhProductDal());
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}
