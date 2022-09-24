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
    public class CreateModelv : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo;
        [BindProperty]
        public Vehiculo Vehiculo{get;set;}

        public CreateModelv(IRepositorioVehiculo repoVehiculo){
           _repoVehiculo=repoVehiculo; 
        }
        public void OnGet(int? id)
        {
            if(id.HasValue)
            {
                Vehiculo= _repoVehiculo.GetVehiculo(id.Value);
            }
            else
            {
                Vehiculo=new Vehiculo();
            }
        }
         public IActionResult OnPost(int? id)
        {
            if(id>0)
            {
                Vehiculo=_repoVehiculo.UpdateVehiculo(Vehiculo);
            }
            else
            {
                _repoVehiculo.AddVehiculo(Vehiculo);
            }
           return new RedirectToPageResult("../linkspage/vehiculos");
        }
    }
}
