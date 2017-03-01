using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomaticMigration.Models
{
    public class LoginUserDetail
    {
        
            public string UserId { get; set; }
            public string Email { get; set; }
            public string RoleName { get; set; }
            public string UserName { get; set; }
            public DateTime DateCreated { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
       
    }
}
