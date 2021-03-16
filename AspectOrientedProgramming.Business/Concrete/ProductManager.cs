using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectOrientedProgramming.Business.Abstract;
using AspectOrientedProgramming.DataAccess.Abstract;
using AspectOrientedProgramming.DataAccess.Concrete.EntityFramework;
using AspectOrientedProgramming.Entities.Concrete;

namespace AspectOrientedProgramming.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları 
            return _productDal.GetAll();
        }
    }
}
