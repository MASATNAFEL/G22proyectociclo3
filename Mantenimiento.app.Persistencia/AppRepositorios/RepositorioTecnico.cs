using System.Collections.Generic;
using System.Linq;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public class RepositorioTecnico:IRepositorioTecnico
    {   
        /// <sumary>
        /// Referencia al contexto de Tecnico
        /// <sumary>
        private readonly AppContext _appContext;
        /// <sumary>
        /// Metodo Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// <sumary>
        /// <param name="appContext"></param>//
        public RepositorioTecnico(AppContext appContext)
        {
            _appContext=appContext;
        }
        Tecnico IRepositorioTecnico.AddTecnico(Tecnico tecnico)
        {
            var tecnicoAdicionado=_appContext.Tecnicos.Add(tecnico);
            _appContext.SaveChanges();
            return tecnicoAdicionado.Entity;
        }
        void IRepositorioTecnico.DeleteTecnico(int idTecnico)
        {
            var tecnicoEncontrado= _appContext.Tecnicos.FirstOrDefault(c => c.Id==idTecnico);
            if(tecnicoEncontrado==null)
            return;
            _appContext.Tecnicos.Remove(tecnicoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Tecnico> IRepositorioTecnico.GetAllTecnicos()
        {
            return _appContext.Tecnicos;
        }
        Tecnico IRepositorioTecnico.GetTecnico(int idTecnico)
        {
            return _appContext.Tecnicos.FirstOrDefault(c => c.Id==idTecnico);
        }
        Tecnico IRepositorioTecnico.UpdateTecnico(Tecnico tecnico)
        {
            var tecnicoEncontrado= _appContext.Tecnicos.FirstOrDefault(c => c.Id==tecnico.Id);
            if(tecnicoEncontrado!=null)
            {
                tecnicoEncontrado.Nombre=tecnico.Nombre;
                tecnicoEncontrado.Apellido=tecnico.Apellido;
                tecnicoEncontrado.Documento=tecnico.Documento;
                tecnicoEncontrado.Direccion=tecnico.Direccion;
                tecnicoEncontrado.User=tecnico.User;
                tecnicoEncontrado.Pass=tecnico.Pass;
                _appContext.SaveChanges();
            }
            return tecnicoEncontrado;
        }
    }
}