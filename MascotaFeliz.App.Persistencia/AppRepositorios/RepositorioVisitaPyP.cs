using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVisitaPyP : IRepositorioVisitaPyP
    {
        /// <summary>
        /// Referencia al contexto de VisitaPyP
        /// </summary>


        private readonly AppContext _appContext;


        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//

        public RepositorioVisitaPyP(AppContext appContext)
        {
            _appContext = appContext;
        }

        public VisitaPyP AddVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPAdicionado = _appContext.VisitasPyP.Add(visitaPyP);
            _appContext.SaveChanges();
            return visitaPyPAdicionado.Entity;
        }

        public void DeleteVisitaPyP(int idVisitaPyP)
        {
            var visitaPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
            if (visitaPyPEncontrado == null)
                return;
            _appContext.VisitasPyP.Remove(visitaPyPEncontrado);
            _appContext.SaveChanges();
        }

      

        public IEnumerable<VisitaPyP> GetAllVisitasPyP()
        {
            return _appContext.VisitasPyP;
        }

        public VisitaPyP GetVisitaPyP(int idVisitaPyP)
        {
            return _appContext.VisitasPyP.FirstOrDefault(d => d.Id == idVisitaPyP);
        }

        public VisitaPyP UpdateVisitaPyP(VisitaPyP visitaPyP)
        {
            var visitaPyPEncontrado = _appContext.VisitasPyP.FirstOrDefault(d => d.Id == visitaPyP.Id);
            if (visitaPyPEncontrado != null)
            {
                visitaPyPEncontrado.FechaVisita = visitaPyP.FechaVisita;
                visitaPyPEncontrado.Temperatura = visitaPyP.Temperatura;
                visitaPyPEncontrado.Peso = visitaPyP.Peso;
                visitaPyPEncontrado.FrecuenciaRespiratoria = visitaPyP.FrecuenciaRespiratoria;
                visitaPyPEncontrado.FrecuenciaCardiaca = visitaPyP.FrecuenciaCardiaca;
                visitaPyPEncontrado.EstadoAnimo = visitaPyP.EstadoAnimo;
                visitaPyPEncontrado.IdVeterinario = visitaPyP.IdVeterinario;
                visitaPyPEncontrado.Recomendaciones = visitaPyP.Recomendaciones;


                _appContext.SaveChanges();
            }
            return visitaPyPEncontrado;
        }    
/*
        public Veterinario AsignarVeterinarios(int idVisitaPyP, int idVeterinario){
    var mascotaEncontrado = _appContext.Mascotas.FirstOrDefault(m => m.Id == idMascota);
    if(mascotaEncontrado != null){
        var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
        if(veterinarioEncontrado != null){
            mascotaEncontrado.veterinario = veterinarioEncontrado;
            _appContext.SaveChanges();
        }
        return veterinarioEncontrado;
    }
    return null;
} */
    }
}