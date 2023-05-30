using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServicioWebWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool Login(string user, string password)
        {
            if (user.Equals("user") && password.Equals("1234"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ProcesarPago(int total, int pago)
        {
            if(pago>= total)
            {
                return pago - total;
            }
            else
            {
                return -1;
            }
        }
    }
}
