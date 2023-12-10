﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();

        List<Brand> GetCarsByBrandId(int id);

        List<Brand> GetCarsByColorId(int id);

        void Add(Brand car);

        void Update(Brand car);

        void Delete(Brand car);
    }
}
