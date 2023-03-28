using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs;
using WebApplication1.Entities;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class ClientController : ControllerBase
    {
        private ClientService clientService { get; set; }


        public ClientController(ClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Client>> GetAll()
        {
            var results = clientService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{studentId}")]
        public ActionResult<Client> GetById(int studentId)
        {
            var result = clientService.GetById(studentId);

            if (result == null)
            {
                return BadRequest("Student not fount");
            }

            return Ok(result);
        }

        [HttpPatch("edit-name")]
        public ActionResult<bool> GetById([FromBody] ClientUpdateDTO studentUpdateModel)
        {
            var result = clientService.EditName(studentUpdateModel);

            if (!result)
            {
                return BadRequest("Student could not be updated.");
            }

            return result;
        }

        [HttpPost("grades-by-course")]
        public ActionResult<OrdersByClient> Get_Orders_ByClienId([FromBody] ClientOrdersRequest request)
        {
            var result = clientService.GetOrdersById(request.ClientId, request.CakeType);
            return Ok(result);
        }

    }
}


   


