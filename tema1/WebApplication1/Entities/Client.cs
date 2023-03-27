using System.Diagnostics;
using System.Security.Claims;

namespace WebApplication1.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int CakeShopId { get; set; }
        public CakeShop CakeShop { get; set; }
        public List<Order> Orders { get; set; }

    }
}
