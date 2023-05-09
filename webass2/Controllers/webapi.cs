using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly List<Order> _orders;

    public OrderController()
    {
        // Initialize the list of orders
        _orders = new List<Order>();
    }

 
    [HttpGet]
    public IEnumerable<Order> Get() => _orders;

    [HttpPost]
    public void Post([FromBody] Order order) => _orders.Add(order);
}