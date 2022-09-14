using System.Collections.Generic;
using System.Linq;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public class RepositorioVehiculo:IRepositorioVehiculo
    {   
        /// <sumary>
        /// Referencia al contexto de Vehiculo
        /// <sumary>
        private readonly ApplicationContext _appContext;
        /// <sumary>
        /// Metodo Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// <sumary>
        /// <param name="appContext"></param>//
        public RepositorioVehiculo(ApplicationContext appContext)
        {
            _appContext=appContext;
        }
        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
        {
            var vehiculoAdicionado=_appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionado.Entity;
        }
        void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
        {
            var vehiculoEncontrado= _appContext.Vehiculos.FirstOrDefault(c => c.Id==idVehiculo);
            if(vehiculoEncontrado==null)
            return;
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }
        Vehiculo IRepositorioVehiculo.GetVehiculo(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(c => c.Id==idVehiculo);
        }
        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo)
        {
            var vehiculoEncontrado= _appContext.Vehiculos.FirstOrDefault(c => c.Id==vehiculo.Id);
            if(vehiculoEncontrado!=null)
            {
                vehiculoEncontrado.Tipo=vehiculo.Tipo;
                vehiculoEncontrado.Placa=vehiculo.Placa;
                vehiculoEncontrado.Modelo=vehiculo.Modelo;
                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;
        }
    }
}