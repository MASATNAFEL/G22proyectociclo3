using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mantenimiento.app.Dominio;
using Mantenimiento.app.Persistencia;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;
        [BindProperty]
        public Cliente Cliente{get;set;}

        public CreateModel(IRepositorioCliente repoCliente){
           _repoCliente=repoCliente; 
        }
        public void OnGet(int? id)
        {
            if(id.HasValue)
            {
                Cliente= _repoCliente.GetCliente(id.Value);
            }
            else
            {
                Cliente=new Cliente();
            }
        }
         public IActionResult OnPost(int? id)
        {
            if(id>0)
            {
                Cliente=_repoCliente.UpdateCliente(Cliente);
            }
            else
            {
                _repoCliente.AddCliente(Cliente);
            }
           return new RedirectToPageResult("../linkspage/clientes");
        }
    }
}
