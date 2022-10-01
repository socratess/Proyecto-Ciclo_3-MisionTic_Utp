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
     private static IRepositorioHistoria _repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
       private static IRepositorioVisitaPyP _repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
      
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddVisita();
            //AddHistoria();
            AsignarVisitaPyP(1004);
            //AddDueno();
            //AddVeterinario();
           //AddMascota();
           //Console.WriteLine("-------------Lista de duenos----------------");
            //ListarDuenos();
            //Console.WriteLine("----------------------Lista de Veterinarios---------------------");
           // ListarVeterinario();
            //Console.WriteLine("---------------------Lista de Mascotas--------------------");
            //ListarMascota();
            //Console.WriteLine("---------------------Asignar Veterinario--------------------");
            //AsignarVeterinario();
            //Console.WriteLine("---------------------Asignar Dueno--------------------");
            //AsignarDueno();
        }

    private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(1000, 09, 21), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 33, Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2000, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", IdVeterinario = 34, Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }


    /*    
  private static void AddVisita()
        {
            var visitaPyP = new VisitaPyP
            {
           
    FechaVisita= DateTime.Now,
    Temperatura = 2.1f, 
    Peso = 2.1f,
    FrecuenciaRespiratoria = 2.1f,
    FrecuenciaCardiaca = 2.1f,
    EstadoAnimo= "alto",
    IdVeterinario  = 33, 
    Recomendaciones = "ssssss" 

            };
    
            _repoVisita.AddVisitaPyP(visitaPyP);
        }*/



private static void AddHistoria()
        {
       
            var historia = new Historia
            {
               
                FechaInicial = DateTime.Now,
    
            
            };
            _repoHistoria.AddHistoria(historia);
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
            foreach (Mascota v in mascotas)
            {
                  Console.WriteLine(v.Nombre + " " + v.Raza+" "+v.dueno);
            }
        }

       private static void AsignarVeterinario(){
            var veterinario = _repoMascota.AsignarVeterinario(7,5);
            Console.WriteLine(veterinario.Nombres+ " "+veterinario.Apellidos);
        }

private static void AsignarDueno(){
            var dueno = _repoMascota.AsignarDueno(7,37);
            Console.WriteLine(dueno.Nombres+ " "+dueno.Apellidos);
}
/*
private static void AsignarVisitaPyP(int idHistoria)
        {
            var historia = _repoHistoria.GetHistoria(idHistoria);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema"});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = new DateTime(2020, 01, 01), Temperatura = 38.0F, Peso = 30.0F, FrecuenciaRespiratoria = 71.0F, FrecuenciaCardiaca = 71.0F, EstadoAnimo = "Muy cansón", CedulaVeterinario = "123", Recomendaciones = "Dieta extrema" }
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
        }*/
    }
}
