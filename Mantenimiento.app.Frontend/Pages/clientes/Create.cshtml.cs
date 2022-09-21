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
         private IRepositorioCliente _repoCliente;

        public Cliente Cliente{get;set;}

        public CreateModel(IRepositorioCliente repoCliente){
           _repoCliente=repoCliente; 
        }
        public void OnGet(int id)
        {
            Cliente= _repoCliente.GetCliente(id);
        }
    }
}
