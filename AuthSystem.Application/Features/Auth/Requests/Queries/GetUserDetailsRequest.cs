﻿using AuthSystem.Application.DTOs.Auth;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.Application.Features.Auth.Requests.Queries
{
    public class GetUserDetailsRequest : IRequest<UserDTO>
    {
        public int Id { get; set; }
    }
}
