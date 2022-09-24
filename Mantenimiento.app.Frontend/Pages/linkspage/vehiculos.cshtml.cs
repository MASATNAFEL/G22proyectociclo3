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
    public class vehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo;
        public IEnumerable<Vehiculo> Vehiculos{get;set;}
        public vehiculosModel(IRepositorioVehiculo repo){
        _repoVehiculo=repo;
        }
                
        public void OnGet()
        {
            Vehiculos=_repoVehiculo.GetAllVehiculos();
        }
       
    }
}
