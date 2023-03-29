using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Entities;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : ControllerBase
    {
        private ClientService clientService { get; set; }


        public ClientController(ClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet("/getAllClients")]
        public ActionResult<List<Client>> GetAll()
        {
            var results = clientService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{clientId}")]
        public ActionResult<Client> GetById(int clientId)
        {
            var result = clientService.GetById(clientId);

            if (result == null)
            {
                return BadRequest("Client not found");
            }

            return Ok(result);
        }

        [HttpPatch("EDIT")]
        public ActionResult<bool> GetById([FromBody] ClientUpdateDTO clientUpdateModel)
        {
            var result = clientService.EditName(clientUpdateModel);

            if (!result)
            {
                return BadRequest("Client could not be updated.");
            }

            return result;
        }

        [HttpPost("orders-by-cake")]
        public ActionResult<OrdersByClient> Get_Orders_ByClientId([FromBody] ClientOrdersRequest request)
        {
            var result = clientService.GetOrdersById(request.ClientId, request.CakeType);
            return Ok(result);
        }

        [HttpDelete("delete/{id}")]
        public ActionResult<ClientDTO>DeleteClient(int clientId)
        {
            try
            {
                var clientToDelete = clientService.GetById(clientId);

                if (clientToDelete == null)
                {
                    return NotFound($"Client not found");
                }

                return clientService.DeleteClient(clientId);
            }
            catch (Exception)
            {
                return BadRequest("Client could not be deleted.");
            }

        }

    }
}


   


