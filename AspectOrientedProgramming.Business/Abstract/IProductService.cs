using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectOrientedProgramming.Entities.Concrete;

namespace AspectOrientedProgramming.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
    }
}
