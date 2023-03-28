using WebApplication1.Database;
using WebApplication1.Entities;
using WebApplication1.Enums;

namespace WebApplication1.Repositories
{

    public class ClientRepository
    {
        public List<Client> GetAll()
        {
            var results = DbContext.Clients;

            return results;
        }

        public Client GetById(int clientId)
        {
            var result = DbContext.Clients
                .Where(e => e.Id == clientId)
                .FirstOrDefault();

            return result;
        }

        public Client GetByIdWithOrders(int clientId, CakeType type)
        {
            var result = DbContext.Clients
               .Select(e => new Client
               {
                   FirstName = e.FirstName,
                   LastName = e.LastName,
                   Id = e.Id,
                   CakeShopId = e.CakeShopId,
                   Orders = e.Orders
                        .Where(g => g.Cake == type)
                        .OrderByDescending(g => g.Quantity)
                        .ToList()
               })
               .FirstOrDefault(e => e.Id == clientId);

            return result;
        }
    }

}
