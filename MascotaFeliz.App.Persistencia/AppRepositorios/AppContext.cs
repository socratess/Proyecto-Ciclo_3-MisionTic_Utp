using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;

namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext{

        public DbSet<Persona> Personas{ get; set; }
        public DbSet<Mascota> Mascotas{ get; set; }  
        public DbSet<Veterinario> Veterinarios{ get; set; }
        public DbSet<Dueno> Duenos{ get; set; }
        public DbSet<Historia> Historias{ get; set; }
        public DbSet<VisitaPyP> VisitasPyP{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder  optionsBuilder){
               if (!optionsBuilder.IsConfigured)
            {
           //     optionsBuilder
             //   .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFelizData");
           
            optionsBuilder
                .UseSqlServer("Data Source = MascotaFelizdb12.mssql.somee.com; Initial Catalog = MascotaFelizdb12;user id=soc_SQLLogin_1;pwd=iwhe57equ1 ");
           
            }

        }
    }
}