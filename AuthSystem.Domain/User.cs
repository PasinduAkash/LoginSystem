using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystem.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }  
        public string Password { get; set; }
        
        public string oAuthType { get; set;}
        public string oAuthId { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }

        public int role {  get; set; }

    }
}
