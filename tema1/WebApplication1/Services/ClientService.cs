using WebApplication1.DTOs;
using WebApplication1.Entities;
using WebApplication1.Enums;
using WebApplication1.Mapping;
using WebApplication1.Repositories;

namespace WebApplication1.Services
{
    public class ClientService
    {
        private ClientRepository clientRepository { get; set; }

        public ClientService(ClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public List<Client> GetAll()
        {
            var results = clientRepository.GetAll();

            return results;
        }

        public ClientDTO GetById(int clientId)
        {
            var client = clientRepository.GetById(clientId);

            var result = client.ToClientDto();

            return result;
        }

        public bool EditName(ClientUpdateDTO payload)
        {
            if (payload == null || payload.FirstName == null || payload.LastName == null)
            {
                return false;
            }

            var result = clientRepository.GetById(payload.Id);
            if (result == null) return false;

            result.FirstName = payload.FirstName;
            result.LastName = payload.LastName;

            return true;
        }

        public OrdersByClient GetOrdersById(int clientId, CakeType cakeType)
        {
            var clientWithOrders = clientRepository.GetByIdWithOrders(clientId, cakeType);
          

            var result = new OrdersByClient(clientWithOrders);

            return result;
        }
        public ClientDTO DeleteClient(int clientId)
        {
            var result = clientRepository.DeleteClient(clientId);
            return result.ToClientDto();
        }
    }
}
