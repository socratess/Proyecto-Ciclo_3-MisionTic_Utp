using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
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
        
        public RepositorioHistoria(AppContext appContext)
        {
            _appContext = appContext;
        }

         public Historia AddHistoria(Historia historia)
        {
            var historiaAdicionada = _appContext.Historias.Add(historia);
            _appContext.SaveChanges();
            return historiaAdicionada.Entity;
        }
        public Historia GetHistoriaTime(DateTime historiaTime){
                 return _appContext.Historias.FirstOrDefault(d => d.FechaInicial == historiaTime);
        }
       

        public IEnumerable<Historia> GetAllHistorias()
        {
        
            return _appContext.Historias.Include("VisitasPyP");
        }

        public void DeleteHistoria(int idHistoria){
            var historiaEncontrada = _appContext.Historias.FirstOrDefault(d => d.Id == idHistoria);
            if (historiaEncontrada == null)
                return;
            _appContext.Historias.Remove(historiaEncontrada);
            _appContext.SaveChanges();
        }

      public Historia GetHistoria(int idHistoria)
        {
            return _appContext.Historias.Include("VisitasPyP").FirstOrDefault(d => d.Id == idHistoria);
        }

        public Historia UpdateHistoria(Historia historia)
        {
            var historiaEncontrado = _appContext.Historias.FirstOrDefault(d => d.Id == historia.Id);
            if (historiaEncontrado != null)
            {
                historiaEncontrado.FechaInicial = historia.FechaInicial;
                historiaEncontrado.VisitasPyP = historia.VisitasPyP;

                _appContext.SaveChanges();
            }
            return historiaEncontrado;
        }        



    }}