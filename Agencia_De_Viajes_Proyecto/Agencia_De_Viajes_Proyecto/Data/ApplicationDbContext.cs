using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Agencia_De_Viajes_Proyecto.Models;

namespace Agencia_De_Viajes_Proyecto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Agencia_De_Viajes_Proyecto.Models.Destino> Destino { get; set; }
        public DbSet<Agencia_De_Viajes_Proyecto.Models.Hotel> Hotel { get; set; }
        public DbSet<Agencia_De_Viajes_Proyecto.Models.Paquete> Paquete { get; set; }
    }
}
