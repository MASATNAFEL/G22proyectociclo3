using System.Collections.Generic;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Tecnico> GetAllTecnicos();
        Tecnico AddTecnico(Tecnico tecnico);
        Tecnico UpdateTecnico(Tecnico tecnico);
        void DeleteTecnico(int idTecnico);
        Tecnico GetTecnico(int idTecnico);
    }
}