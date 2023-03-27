using WebApplication1.Enums;

namespace WebApplication1.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public CakeType Cake { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
