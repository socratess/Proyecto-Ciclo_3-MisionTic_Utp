using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Frontend.Pages
{
    public class RegistrarVisitasModel : PageModel
     {

        private readonly IRepositorioVisitaPyP _repoVisita;
        private readonly IRepositorioVeterinario _repoVeterinario;
          private readonly IRepositorioHistoria _repoHistoria;
         
   
        [BindProperty]
        public VisitaPyP visita { get; set; }
        public Veterinario veterinario { get; set; }
        public Historia historia {get;set;}
        
        public IEnumerable<VisitaPyP> listaVisitas { get; set; }
        public IEnumerable<Veterinario> listaVeterinarios { get; set; }
        public IEnumerable<Historia> listaHistorias { get; set; }

        public RegistrarVisitasModel()
        {
            this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
        }


        public void OnGet()
        {
            
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();
            listaHistorias = _repoHistoria.GetAllHistorias();
           
            visita = new VisitaPyP();
         
            if (visita == null)
            {
                RedirectToPage("./NotFound");
            }
                Page();
        }

public IActionResult OnPost(VisitaPyP visita,int veterinarioId,int historiaId){


   Console.Write("sss"+visita.FechaVisita);
            var historia = _repoHistoria.GetHistoria(historiaId);
            if (historia != null)
            {
                if (historia.VisitasPyP != null)
                {
                    historia.VisitasPyP.Add(new VisitaPyP { FechaVisita = visita.FechaVisita, Temperatura = visita.Temperatura, Peso = visita.Peso, FrecuenciaRespiratoria = visita.FrecuenciaRespiratoria, FrecuenciaCardiaca = visita.FrecuenciaCardiaca, EstadoAnimo = visita.EstadoAnimo, IdVeterinario = veterinarioId, Recomendaciones = visita.Recomendaciones});
                }
                else
                {
                    historia.VisitasPyP = new List<VisitaPyP>{
                        new VisitaPyP{FechaVisita = visita.FechaVisita, Temperatura =visita.Temperatura, Peso = visita.Peso, FrecuenciaRespiratoria = visita.FrecuenciaRespiratoria, FrecuenciaCardiaca = visita.FrecuenciaCardiaca, EstadoAnimo = visita.EstadoAnimo, IdVeterinario = veterinarioId, Recomendaciones = visita.Recomendaciones}
                    };
                }
                _repoHistoria.UpdateHistoria(historia);
            }
   
            //_repoVisita.AddVisitaPyP(visitasPyP);

    
                return RedirectToPage("/Visitas/ListaVisitas");
        
            
}


    }}
