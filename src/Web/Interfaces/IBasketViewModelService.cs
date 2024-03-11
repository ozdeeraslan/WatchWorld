﻿using Web.Models;

namespace Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketViewModel> GetBasketViewModelAsync();

        Task<BasketViewModel> AddItemToBasketAsync(int productId, int quantity);

        Task EmptyBasketAsync();

        Task RemoveItemAsync(int productId);

        Task<BasketViewModel> SetQuantitiesAsync(Dictionary<int, int> quantities);
    }
}
