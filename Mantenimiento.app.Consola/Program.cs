using System.Net.WebSockets;
using System;
using Mantenimiento.app.Dominio;
using Mantenimiento.app.Persistencia;

namespace Mantenimiento.app.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente= new RepositorioCliente(new Persistencia.ApplicationContext());
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            AddCliente(); 
            ImprimirClientes();           
            
        }
        private static void ImprimirClientes()
        {
            var clientes = _repoCliente.GetAllClientes();
            Console.WriteLine("los cliente son: ");
            foreach (var cliente in clientes)
            {
                Console.WriteLine(cliente.Nombre+" "+cliente.Apellido+" "+cliente.Documento+" "+cliente.Direccion);
            }
        }
        private static void AddCliente()
        {
            var cliente = new Cliente{
                Nombre="miguel",
                Apellido="pelaez",
                Documento=10000002,
                Direccion="villa perdida2",
                Telefono="6060000002",
                correo="done2@notiene.com",
                User="elfue1",
                Pass="theend"
            };
            
            _repoCliente.UpdateCliente(cliente);
        }
    }
}
