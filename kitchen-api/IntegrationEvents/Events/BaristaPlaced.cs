using KitchenApi.Domain.Dtos;

namespace CoffeeShop.MessageContracts;

public record KitchenOrderPlaced
{
    public Guid OrderId { get; init; }
    public List<OrderItemDto> ItemLines { get; init; } = new();
}