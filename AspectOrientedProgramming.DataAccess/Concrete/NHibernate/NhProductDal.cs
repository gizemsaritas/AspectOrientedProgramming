﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectOrientedProgramming.DataAccess.Abstract;
using AspectOrientedProgramming.Entities.Concrete;

namespace AspectOrientedProgramming.DataAccess.Concrete.NHibernate
{
    public class NhProductDal:IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {Id = 1, Name = "TV"}
            };
        }
    }
}
