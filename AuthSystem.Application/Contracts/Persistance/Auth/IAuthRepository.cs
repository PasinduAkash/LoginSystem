using AuthSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.Application.Contracts.Persistance.Auth
{
    public interface IAuthRepository : IGenericRepository<User>
    {

    }
}
