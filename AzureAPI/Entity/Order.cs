using System.Net;

namespace AzureAPI.Entity
{
    public class Order
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public Address ShippingAddress { get; set; }
        public Customer Customer { get; set; }
    }
}
