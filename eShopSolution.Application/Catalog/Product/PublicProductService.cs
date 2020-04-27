using eShopSolution.Application.Catalog.Product.Dtos;
using eShopSolution.Application.Catalog.Product.Dtos.Public;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.Product
{
    public class PublicProductService : IPublicProductService
    {
        public PagedResuilt<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request)
        {
            
        }
    }
}
