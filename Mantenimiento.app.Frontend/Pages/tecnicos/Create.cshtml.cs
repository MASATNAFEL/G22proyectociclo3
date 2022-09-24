using System.Net.WebSockets;
using System.Net.Http;
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
    public class CreateModelt : PageModel
    {
        private readonly IRepositorioTecnico _repoTecnico;
        [BindProperty]
        public Tecnico Tecnico{get;set;}

        public CreateModelt(IRepositorioTecnico repoTecnico){
           _repoTecnico=repoTecnico; 
        }
        public void OnGet(int? id)
        {
            if(id.HasValue)
            {
                Tecnico= _repoTecnico.GetTecnico(id.Value);
            }
            else
            {
                Tecnico=new Tecnico();
            }
        }
         public IActionResult OnPost(int? id)
        {
            if(id>0)
            {
                if(Tecnico.User==null){
                Tecnico.User=""+Tecnico.Documento;    
                }
                if(Tecnico.Pass==null){
                Tecnico.Pass=""+Tecnico.Documento;    
                }
                Tecnico=_repoTecnico.UpdateTecnico(Tecnico);
            }
            else
            {
                Tecnico.User=""+Tecnico.Documento;
                Tecnico.Pass=""+Tecnico.Documento;
                _repoTecnico.AddTecnico(Tecnico);
            }
           return new RedirectToPageResult("../linkspage/tecnicos");
        }
    }
}
