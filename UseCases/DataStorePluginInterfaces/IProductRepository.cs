﻿using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public interface IProductRepository(Product product)
    {
        IEnumerable<Product> GetProducts();
        void AddProduct();
    }
}
