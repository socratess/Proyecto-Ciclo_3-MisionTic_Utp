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
    public class RegistrarDuenoModel : PageModel
    {
         private readonly IRepositorioDueno _repoDueno;
        [BindProperty]
        public Dueno dueno { get; set; }

        public RegistrarDuenoModel()
        {
            this._repoDueno = new RepositorioDueno(new Persistencia.AppContext());
        }

        public IActionResult OnGet()
        {
            dueno = new Dueno();
            if (dueno == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            
                _repoDueno.AddDueno(dueno);
            
            return Page();
        }
    }
}
    