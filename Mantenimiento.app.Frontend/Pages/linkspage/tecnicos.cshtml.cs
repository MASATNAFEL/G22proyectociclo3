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
    public class tecnicosModel : PageModel
    {
        private readonly IRepositorioTecnico _repoTecnico;
        public IEnumerable<Tecnico> Tecnicos{get;set;}
        public tecnicosModel(IRepositorioTecnico repo){
        _repoTecnico=repo;
        }
                
        public void OnGet()
        {
            Tecnicos=_repoTecnico.GetAllTecnicos();
        }
       
    }
}
