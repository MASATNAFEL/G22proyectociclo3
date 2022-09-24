using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mantenimiento.app.Dominio;
using Mantenimiento.app.Persistencia;

namespace Mantenimiento.app.Frontend.Pages
{
    public class DeleteModelt : PageModel
    {
        private IRepositorioTecnico _repoTecnico;

        public Tecnico Tecnico{get;set;}

        public DeleteModelt(IRepositorioTecnico repoTecnico){
           _repoTecnico=repoTecnico; 
        }
        public void OnGet(int id)
        {
           Tecnico= _repoTecnico.GetTecnico(id);           
        }
        public IActionResult OnPost(int id)
        {
           _repoTecnico.DeleteTecnico(id);
           return new RedirectToPageResult("../linkspage/tecnicos");
        }
    }
}
