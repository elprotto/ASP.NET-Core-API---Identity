using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleProject.Models
{
    public class User: IdentityUser
    {
        public int CedulaId { get; set; }
        public string MyCustomProperty { get; set; }
        public virtual ICollection<IdentityRole> UserRoles { get; set; }
    }
}
