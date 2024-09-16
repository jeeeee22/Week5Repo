using IndustryConnect_Week5_WebApi.Dtos;
using IndustryConnect_Week5_WebApi.Models;

namespace IndustryConnect_Week5_WebApi.Mappers
{
    public static class SaleMapper
    {
        public static SaleDto EntityToDto(Sale sale)
        {
            return new SaleDto
            {
                Id = sale.Id,
                CustomerName = $"{sale.Customer?.FirstName} {sale.Customer?.LastName}",
                ProductName = sale.Product?.Name,
                StoreName = sale.Store?.Name,
                DateSold = sale.DateSold,
                Price = sale.Product?.Price
            };
        }
    }
}
