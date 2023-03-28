using System.ComponentModel.DataAnnotations;
using WebApplication1.Enums;

namespace WebApplication1.DTOs
{
    public class ClientOrdersRequest
    {

        [Required]
        public int ClientId { get; set; }

        [Required]
        public CakeType CakeType { get; set; }

    }
}
