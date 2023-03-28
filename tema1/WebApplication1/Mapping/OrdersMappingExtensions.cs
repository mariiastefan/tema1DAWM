using System.Diagnostics;
using WebApplication1.DTOs;
using WebApplication1.Entities;

namespace WebApplication1.Mapping
{
    public static class OrdersMappingExtensions
    {
        public static List<OrderDTO> ToOrderDtos(this List<Order> orders)
        {
            var results = orders.Select(e => e.ToOrderDto()).ToList();

            return results;
        }

        public static OrderDTO ToOrderDto(this Order order)
        {
            if (order == null) return null;

            var result = new OrderDTO();
            result.Quantity = order.Quantity;
            result.Cake = order.Cake;
            result.Address = order.Address;

            return result;
        }
    }
}
