using ApplicationCore.Entities;
using Web.Models;

namespace Web.Extensions
{
    public static class MappingExtensions
    {
        public static BasketViewModel ToBasketViewModel(this Basket basket)
        {
            return new BasketViewModel()
            {
                Id = basket.Id,
                BuyerId = basket.BuyerId,
                Items = basket.Items.Select(x => new BasketItemViewModel()
                {
                    Id = x.Id,
                    ProductId = x.ProductId,
                    Quantity = x.Quantity,
                    PictureUri = x.Product.PictureUri ?? "noimage.jpg",
                    ProductName = x.Product.Name,
                    UnitPrice = x.Product.Price
                }).ToList()
            };
        }
    }
}
