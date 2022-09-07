using System.Collections.Generic;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public interface IRepositorioVehiculo
    {
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int idVehiculo);
        Vehiculo GetVehiculo(int idVehiculo);
    }
}