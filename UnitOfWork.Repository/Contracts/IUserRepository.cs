using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System;
using System.Text;

namespace App.Repository.Contracts
{
    public interface IUserRepository
    {

        List<IdentityUser> GetUsersAll();

        IdentityUser GetUserById(int id);

    }
}
