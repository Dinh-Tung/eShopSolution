using eShopSolution.Application.Catalog.Product.Dtos;
using eShopSolution.Application.Catalog.Product.Dtos.Manage;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.Product
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task addViewCount(int productId);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task<int> Delete(int productId);


        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }

    
}
