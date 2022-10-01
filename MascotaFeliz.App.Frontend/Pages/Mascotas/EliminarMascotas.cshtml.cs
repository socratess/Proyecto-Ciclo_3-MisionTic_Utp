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
    public class EliminarMascotasModel : PageModel
    {

         private readonly IRepositorioMascota _repoMascota;
         private readonly IRepositorioHistoria _repoHistoria;
         private readonly IRepositorioVisitaPyP _repoVisita;
         public Mascota mascota {get;set;}
         public Historia historia {get;set;}
         public VisitaPyP visita { get; set; }

        
        public EliminarMascotasModel(){
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
             this._repoVisita = new RepositorioVisitaPyP(new Persistencia.AppContext());
        }

         public  IActionResult OnGet(int mascotaId)

        {
            mascota = _repoMascota.GetMascota(mascotaId);
          
             historia = _repoHistoria.GetHistoria(mascota.historia.Id);
            Console.Write("Valor cantidad de visitas en historia: "+historia.VisitasPyP.Count);
             int tamn = historia.VisitasPyP.Count;
            List<VisitaPyP> VisitasPyPs =  historia.VisitasPyP;
          
            _repoMascota.DeleteMascota(mascotaId);
               _repoHistoria.DeleteHistoria(mascota.historia.Id);
                
                for (int i=0; i<tamn; i++){
                 Console.Write(VisitasPyPs[i].Id);
                 visita = _repoVisita.GetVisitaPyP(VisitasPyPs[i].Id);
                 if (visita != null){ _repoVisita.DeleteVisitaPyP(visita.Id);}
               
             }






            if(mascota==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }  
        }
    }
}
