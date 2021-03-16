using System.Collections.Generic;
using AspectOrientedProgramming.Business.Abstract;
using AspectOrientedProgramming.Core.Aspects;
using AspectOrientedProgramming.Core.CrossCuttingConcerns.Caching;
using AspectOrientedProgramming.Core.CrossCuttingConcerns.Logging;
using AspectOrientedProgramming.DataAccess.Abstract;
using AspectOrientedProgramming.Entities.Concrete;

namespace AspectOrientedProgramming.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private readonly IProductDal _productDal;
        private ILogger _logger;
        private ICache _cache;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [LogAspect]
        public List<Product> GetAll()
        {
            //iş kodları 
            return _productDal.GetAll();
        }
    }
}
