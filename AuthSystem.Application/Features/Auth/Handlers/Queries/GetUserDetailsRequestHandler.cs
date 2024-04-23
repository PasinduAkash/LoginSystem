using AuthSystem.Application.DTOs.Auth;
using AuthSystem.Application.Features.Auth.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.Application.Features.Auth.Handlers.Queries
{
    public class GetUserDetailsRequestHandler : IRequestHandler<GetUserDetailsRequest, UserDTO>
    {
        public GetUserDetailsRequestHandler()
        {
            
        }

        public Task<UserDTO> Handle(GetUserDetailsRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
