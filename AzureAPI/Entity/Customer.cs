using System.Net;

namespace AzureAPI.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
