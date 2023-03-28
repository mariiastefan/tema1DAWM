namespace WebApplication1.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int CakeShopId { get; set; }
        public string CakeShopName { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
