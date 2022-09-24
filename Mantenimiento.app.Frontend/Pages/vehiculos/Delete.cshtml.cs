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
    public class DeleteModelv : PageModel
    {
        private IRepositorioVehiculo _repoVehiculo;

        public Vehiculo Vehiculo{get;set;}

        public DeleteModelv(IRepositorioVehiculo repoVehiculo){
           _repoVehiculo=repoVehiculo; 
        }
        public void OnGet(int id)
        {
           Vehiculo= _repoVehiculo.GetVehiculo(id);           
        }
        public IActionResult OnPost(int id)
        {
           _repoVehiculo.DeleteVehiculo(id);
           return new RedirectToPageResult("../linkspage/vehiculos");
        }
    }
}
