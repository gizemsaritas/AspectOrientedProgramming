using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectOrientedProgramming.Entities.Concrete;

namespace AspectOrientedProgramming.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}
