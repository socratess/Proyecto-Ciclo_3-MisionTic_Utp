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
    public class RegistrarMascotasModel : PageModel
    {

        private readonly IRepositorioMascota _repoMascota;
        private readonly IRepositorioDueno _repoDueno;
        private readonly IRepositorioVeterinario _repoVeterinario;
        private readonly IRepositorioHistoria _repoHistoria;
   
        [BindProperty]
        public Mascota mascota { get; set; }
        public Veterinario veterinario { get; set; }
        public Dueno dueno { get; set; }
        public Historia histori { get; set; }
        public IEnumerable<Dueno> listaDuenos { get; set; }
        public IEnumerable<Veterinario> listaVeterinarios { get; set; }

        public RegistrarMascotasModel()
        {
            this._repoMascota = new RepositorioMascota(new Persistencia.AppContext());
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
            this._repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
            this._repoHistoria = new RepositorioHistoria(new Persistencia.AppContext());
   
        }


        public void OnGet()
        {
            listaDuenos = _repoDueno.GetAllDuenos();
            listaVeterinarios = _repoVeterinario.GetAllVeterinarios();

           
            mascota = new Mascota();
         
            if (mascota == null)
            {
                RedirectToPage("./NotFound");
            }
                Page();
        }

public IActionResult OnPost(Mascota mascota,int duenoId,int veterinarioId){

            {
              
              dueno = _repoDueno.GetDueno(duenoId);

              
            veterinario = _repoVeterinario.GetVeterinario(veterinarioId);
                             
                    
                mascota = _repoMascota.AddMascota(mascota);
              
                _repoMascota.AsignarDueno(mascota.Id,dueno.Id);
               _repoMascota.AsignarVeterinario(mascota.Id,veterinario.Id);
                   

                  DateTime fechaInicial = DateTime.Now;
                 var historia = new Historia{FechaInicial = fechaInicial};
                 _repoHistoria.AddHistoria(historia);
                     
                  histori=_repoHistoria.GetHistoriaTime(fechaInicial);   
                   //Falta consultar hsitoria
                 
                 _repoMascota.AsignarHistoria(mascota.Id,histori.Id);

                return RedirectToPage("/Mascotas/ListaMascotas");
        
            
}


    }}}
