using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationUser
{
    public class CurrentUser
    {
        public CurrentUser(string id, string email)
        {
            Id = id;
            //UserName= userName;
            Email= email;
        }
        public string Id { get; set; }
        //public string UserName { get; set;}
        public string Email { get; set; }
    }
}
