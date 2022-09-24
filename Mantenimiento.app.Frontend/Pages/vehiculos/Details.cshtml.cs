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
    public class DetailsModelv : PageModel
    {
        private IRepositorioVehiculo _repoVehiculo;

        public Vehiculo Vehiculo{get;set;}

        public DetailsModelv(IRepositorioVehiculo repoVehiculo){
           _repoVehiculo=repoVehiculo; 
        }
        public void OnGet(int id)
        {
           Vehiculo= _repoVehiculo.GetVehiculo(id);           
        }
    }
}
