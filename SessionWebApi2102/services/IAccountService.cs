using Microsoft.AspNetCore.Identity;
using SessionWebApi2102.data;
using SessionWebApi2102.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionWebApi2102.services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateUser(SignUpModel signUpModel);
        Task<SignInResult> CheckPassword(SignInModel signInModel);

        Task<IdentityResult> NewRole(RoleModel roleModel);

        List<IdentityRole> GetRoles();

        Task Logout();

        Task<ApplicationUser> GetUser(string username);

        List<string> GetUserRoles(ApplicationUser user);
    }
}
