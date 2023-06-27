using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.ApplicationUser
{
    public class UserContext : IUserContext
    {
        private readonly IHttpContextAccessor _contextAccessor;
        public UserContext(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public CurrentUser GetCurrentUser()
        {
            var user = _contextAccessor?.HttpContext?.User;
            if (user == null)
            {
                throw new InvalidOperationException("Context user is not present");
            }

            var id = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)!.Value;
            var email = user.FindFirst(c => c.Type == ClaimTypes.Email)!.Value;
            //var userName = user.FindFirst(c => c.Type == ClaimTypes.Name)!.Value;

            return new CurrentUser(id, email);
        }
    }
}
