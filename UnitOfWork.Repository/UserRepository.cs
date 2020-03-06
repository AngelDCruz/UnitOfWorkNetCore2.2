using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

using App.Datos.Datos;
using App.Datos.Repository;
using App.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace App.Repository
{
    public class UserRepository : GenericRepository<IdentityUser> ,IUserRepository
    {

        private readonly DatosDbContext _context;

        public UserRepository(DatosDbContext context) : base(context)
        {
            _context = context;
        }

        public List<IdentityUser> GetUsersAll()
        {
            return _context.Users.ToList();
        }

        public IdentityUser GetUserById(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
