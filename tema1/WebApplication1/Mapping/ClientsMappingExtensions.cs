using WebApplication1.DTOs;
using WebApplication1.Entities;

namespace WebApplication1.Mapping
{
    public static class ClientsMappingExtensions
    {
        public static ClientDTO ToClientDto(this Client client)
        {
            if (client == null) return null;

            var result = new ClientDTO();
            result.Id = client.Id;
            result.FullName = client.FirstName + " " + client.LastName;
            result.CakeShopId = client.CakeShopId;
            result.CakeShopName = client.CakeShop.Name;
            result.Orders = client.Orders.ToOrderDtos();

            return result;
        }
    }
}
