using System.Collections.Generic;
using System.Linq;
using Mantenimiento.app.Dominio;

namespace Mantenimiento.app.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    {   
        /// <sumary>
        /// Referencia al contexto de Cliente
        /// <sumary>
        private readonly ApplicationContext _appContext;
        /// <sumary>
        /// Metodo Constructor Utiliza
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// <sumary>
        /// <param name="appContext"></param>//
        public RepositorioCliente(ApplicationContext appContext)
        {
            _appContext=appContext;
        }
        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAdicionado=_appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }
        void IRepositorioCliente.DeleteCliente(int idCliente)
        {
            var clienteEncontrado= _appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
            if(clienteEncontrado==null)
            return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.Clientes;
        }
        Cliente IRepositorioCliente.GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.Id==idCliente);
        }
        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado= _appContext.Clientes.FirstOrDefault(c => c.Id==cliente.Id);
            if(clienteEncontrado!=null)
            {
                clienteEncontrado.Nombre=cliente.Nombre;
                clienteEncontrado.Apellido=cliente.Apellido;
                clienteEncontrado.Documento=cliente.Documento;
                clienteEncontrado.Direccion=cliente.Direccion;
                clienteEncontrado.Telefono=cliente.Telefono;
                clienteEncontrado.correo=cliente.correo;
                clienteEncontrado.placa=cliente.placa;
                clienteEncontrado.User=cliente.User;
                clienteEncontrado.Pass=cliente.Pass;
                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
    }
}