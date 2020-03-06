using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Datos.Datos
{
    public class DatosDbContext :  IdentityDbContext
    {

        public DatosDbContext(DbContextOptions<DatosDbContext> options) : base(options)
        {

        }
        public DatosDbContext() {}

    }
}
