using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Product.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
