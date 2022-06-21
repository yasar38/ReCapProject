﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<Car> GetCarsByBrandId(Expression<Func<Car, bool>> filter);
        List<Car> GetCarsByColorId(Expression<Func<Car, bool>> filter);

    }
}