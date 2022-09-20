using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
    private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());
    private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
    private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddDueno();
            //AddVeterinario();
            //AddMascota();
            Console.WriteLine("-------------Lista de duenos----------------");
            ListarDuenos();
            Console.WriteLine("----------------------Lista de Veterinarios---------------------");
            ListarVeterinario();
            Console.WriteLine("---------------------Lista de Mascotas--------------------");
            ListarMascota();
        }
        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "laurent",
                Apellidos = "Music",
                Direccion = "Hotel",
                Telefono = "1234567425",
                Correo = "laurentm@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }
	private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }
        	
 private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Lebron",
                Apellidos = "Robert",
                Direccion = "Casa",
                Telefono = "5338954541",
                TarjetaProfesional = "102306524"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

	private static void ListarVeterinario()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario v in veterinarios)
            {
                Console.WriteLine(v.Nombres + " " + v.Apellidos);
            }
        }


 private static void AddMascota()
        {
            var mascota = new Mascota
            {
                //Cedula = "1212",
                Nombre = "Orlan",
                Color = "Negro",
                Especie = "Perro",
                Raza = "Pitbull",
               // dueno = "Juan",
                //veterinario = "Pedro",
                //historia = "12635"
            };
            _repoMascota.AddMascota(mascota);
        }
private static void ListarMascota()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota m in mascotas)
            {
                
            }
        }

      /*  private static void AsignarVeterinario(){
            var veterinario = _repoMascota.AsignarVeterionario(1,15);
          //  Console.WriteLine(veterinario.Nombres);
        }*/

    }
}
