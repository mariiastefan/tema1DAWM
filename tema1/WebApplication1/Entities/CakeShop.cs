namespace WebApplication1.Entities
{
    public class CakeShop
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Client> Clients { get; set; }
    }
}
