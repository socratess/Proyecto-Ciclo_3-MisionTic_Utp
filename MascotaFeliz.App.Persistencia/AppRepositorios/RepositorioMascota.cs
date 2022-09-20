using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        /// <summary>
        /// Referencia al contexto de Dueno
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioMascota(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaAdicionado = _appContext.Mascotas.Add(mascota);
            _appContext.SaveChanges();
            return mascotaAdicionado.Entity;
        }

        public void DeleteMascota(int idMascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
            if (mascotaEncontrado == null)
                return;
            _appContext.Mascotas.Remove(mascotaEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContext.Mascotas;
        }

        public IEnumerable<Mascota> GetMascotasPorFiltro(string filtro)
        {
            var mascotas = GetAllMascotas(); // Obtiene todos los saludos
            if (mascotas != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    mascotas = mascotas.Where(s => s.Nombre.Contains(filtro));
                }
            }
            return mascotas;
        }

        public Mascota GetMascota(int idMascota)
        {
            return _appContext.Mascotas.FirstOrDefault(d => d.Id == idMascota);
        }


/*public Veterinario AsignarVeterinario(int idMascota, int idVeterinario){
    var mascotaEncontrado = __appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
    if(mascotaEncontrado != null){
        var veterinarioEncontrado = __appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        if(veterinarioEncontrado!=null){
            mascotaEncontrado.Veterinario = veterinarioEncontrado;
            _appContext.SaveChanges();
        }
        return veterinarioEncontrado;
    }
    return null;
}*/





        public Mascota UpdateMascota(Mascota mascota)
        {
            var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(d => d.Id == mascota.Id);
            if (mascotaEncontrado != null)
            {
                mascotaEncontrado.Nombre = mascota.Nombre;
                mascotaEncontrado.Color = mascota.Color;
                mascotaEncontrado.Especie = mascota.Especie;
                mascotaEncontrado.Raza = mascota.Raza;
                mascotaEncontrado.dueno = mascota.dueno;
                mascotaEncontrado.veterinario = mascota.veterinario;
                mascotaEncontrado.historia = mascota.historia;
                _appContext.SaveChanges();
            }
            return mascotaEncontrado;
        }     
    }
}