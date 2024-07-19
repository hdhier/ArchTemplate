using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Customers.Querys.GetAllCustomers
{
    public record GetAllCustomersQuery : IRequest<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, string>
    {
        //private readonly IApplicationDbContext _context;
        //private readonly IMapper _mapper;

        //public GetAllCustomersQueryHandler(IApplicationDbContext context, IMapper mapper)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //}

        public GetAllCustomersQueryHandler()
        {

        }

        public async Task<string> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            return "Hoa";
        }
    }
}
