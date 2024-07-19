using Application.Customers.Commands.CreateCustomer;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mappings
{
    public class MappingExtensions : Profile
    {
        public MappingExtensions()
        {
            CreateMap<CreateCustomerCommand, Customer>();
        }
    }
}
