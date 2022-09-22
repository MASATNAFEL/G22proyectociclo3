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
    public class clientesModel : PageModel
    {
        private readonly IRepositorioCliente _repoCliente;
        public IEnumerable<Cliente> Clientes{get;set;}
        public clientesModel(IRepositorioCliente repo){
        _repoCliente=repo;
        }
                
        public void OnGet()
        {
            Clientes=_repoCliente.GetAllClientes();
        }
       
    }
}
