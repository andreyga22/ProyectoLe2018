using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using AdminBL;
namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public BLCliente ConsultarCliente(string email, string contraseña)
        {
            return new managerCliente().ConsultarClienteConContraseña(email, contraseña);
        }

        public void ingresarUsuario(string nombreUsuario, string primerApellido, string segundoApellido, string telefono, string email, string contrasena)
        {
            BLCliente cliente = new BLCliente(nombreUsuario, primerApellido, segundoApellido, 0, "Cliente", telefono, email, contrasena, true);
            new managerCliente().InsertarCliente(cliente);
        }

        public BLPlato PlatoBusqueda(String codigo)
        {
            return new ManejadorPlatos().buscarPlato(int.Parse(codigo));
        }

        public List<BLPlato> Platos()
        {
            return new ManejadorPlatos().listaPlatos();
        }


    }
}
