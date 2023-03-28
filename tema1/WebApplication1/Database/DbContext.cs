using System.Diagnostics;
using System.Security.Claims;
using WebApplication1.Entities;
using WebApplication1.Enums;

namespace WebApplication1.Database
{
    public static class DbContext
    {
        public static List<CakeShop> Cakeshops = new List<CakeShop>
        {
            new CakeShop
            {
                Id = 1,
                Name = "Lavender",
                Clients = new List<Client>
                {
                    new Client
                    {
                        Id = 1,
                        FirstName = "Alex",
                        LastName = "Popescu",
                        CakeShopId = 1,
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                Id = 1,
                                Quantity= 1,
                                Cake = CakeType.Cheesecake,
                                ClientId = 1
                            },
                            new Order
                            {
                                Id = 2,
                                Quantity= 2,
                                Cake = CakeType.MangoCaramel,
                                ClientId = 1
                            },
                               new Order
                            {
                                Id = 3,
                                Quantity= 3,
                                Cake = CakeType.RedVelvet,
                                ClientId = 1
                            },
                        }
                    },
                    new Client
                    {
                        Id = 2,
                        FirstName = "Ioana",
                        LastName = "Dumitrescu",
                        CakeShopId = 1,
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                Id = 4,
                                Quantity= 2,
                                Cake = CakeType.CarrotCake,
                                ClientId = 2
                            },
                            new Order
                            {
                                Id = 5,
                                Quantity= 2,
                                Cake = CakeType.BlackForrestCake,
                                ClientId = 2
                            },
                               new Order
                            {
                                Id = 6,
                                Quantity= 4,
                                Cake = CakeType.LemonCake,
                                ClientId = 2
                            },
                            new Order
                            {
                                Id = 7,
                                Quantity= 2,
                                Cake = CakeType.Cheesecake,
                                ClientId = 2
                            },
                        }
                    },
                    new Client
                    {
                        Id = 3,
                        FirstName = "Mia",
                        LastName = "Dobre",
                        CakeShopId = 1,
                        Orders = new List<Order>
                        {
                            new Order
                            {
                                Id = 8,
                                Quantity= 3,
                                Cake = CakeType.MangoCaramel,
                                ClientId = 3
                            },
                        }
                    },
                    new Client
                    {
                        Id = 4,
                        FirstName = "Paul",
                        LastName = "Pascu",
                        CakeShopId = 1,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 5,
                        FirstName = "Sonia",
                        LastName = "Balan",
                        CakeShopId = 1,
                        Orders = new List<Order>()
                    },
                }
            },
            new CakeShop
            {
                Id = 2,
                Name = "CuptorulLuiRobert",
                Clients = new List<Client>
                {
                    new Client
                    {
                        Id = 6,
                        FirstName = "Matei",
                        LastName = "Cristea",
                        CakeShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 7,
                        FirstName = "Mara",
                        LastName = "Oprea",
                        CakeShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 8,
                        FirstName = "Clara",
                        LastName = "Dinu",
                        CakeShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 9,
                        FirstName = "Iustin",
                        LastName = "Danu",
                        CakeShopId = 2,
                        Orders = new List<Order>()
                    },
                    new Client
                    {
                        Id = 10,
                        FirstName = "Iulian",
                        LastName = "Ciobanu",
                        CakeShopId = 2,
                        Orders = new List<Order>()
                    },
                }
            }
        };

        public static List<Client> Clients = Cakeshops.SelectMany(x => x.Clients).ToList();

        public static List<Order> Orders = Cakeshops.SelectMany(x => x.Clients.SelectMany(x => x.Orders)).ToList();

    }
}

