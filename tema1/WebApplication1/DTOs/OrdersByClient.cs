using WebApplication1.Entities;

namespace WebApplication1.DTOs
{
    public class OrdersByClient
    {
        public int? ClientId { get; set; }
        public string ClientCompleteName { get; set; }

        public List<OrderDTO> Grades { get; set; } = new();

        public OrdersByClient(Client client)
        {

            ClientId = client?.Id;
            ClientCompleteName = client?.FirstName + " " + client?.LastName;

            if (client?.Orders != null)
            {
                Grades = client.Orders
                    .Select(g => new OrderDTO
                    {
                        Quantity = g.Quantity,
                        Cake = g.Cake
                    })
                    .ToList();
            }
        }
    }
}
