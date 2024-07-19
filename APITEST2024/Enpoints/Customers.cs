using Application.Customers.Commands.CreateCustomer;
using Application.Customers.Querys.GetAllCustomers;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace APITEST2024.Enpoints
{
    public class Customers : EndpointGroupBase
    {
        public override void Map(WebApplication app)
        {
            var group = app.MapGroup(this);

            group.MapGet("/GetAll", GetAllCustomers);
            group.MapPost("/CreateCustomer", CreateCustomer);
        }

        public Task<string> GetAllCustomers(ISender sender, [AsParameters] GetAllCustomersQuery query)
        {
            return sender.Send(query);
        }

        public Task<string> CreateCustomer(ISender sender, [FromBody] CreateCustomerCommand query)
        {
            return sender.Send(query);
        }
    }
}
