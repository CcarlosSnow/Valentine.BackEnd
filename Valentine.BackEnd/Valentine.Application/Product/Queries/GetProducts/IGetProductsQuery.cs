﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMultiplica.Application.Product.Queries.GetProducts
{
    public interface IGetProductsQuery
    {
        List<GetProductsModel> Execute();
    }
}
