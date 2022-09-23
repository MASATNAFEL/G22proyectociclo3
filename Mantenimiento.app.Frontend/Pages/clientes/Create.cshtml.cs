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
                if(Cliente.User==null){
                Cliente.User=Cliente.correo;    
                }
                if(Cliente.Pass==null){
                Cliente.Pass=""+Cliente.Documento;    
                }
                Cliente=_repoCliente.UpdateCliente(Cliente);
            }
            else
            {
                Cliente.User=Cliente.correo;
                Cliente.Pass=""+Cliente.Documento;
                _repoCliente.AddCliente(Cliente);
            }
           return new RedirectToPageResult("../linkspage/clientes");
        }
    }
}
