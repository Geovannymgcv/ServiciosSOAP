using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteNET
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            //Login
            if (cliente.Login("user", "1234"))
            {
                Console.WriteLine("Todo correcto");
            }
            else
            {
                Console.WriteLine("Usuario Incorrecto");
            }
            //Procesar pago
            if (cliente.ProcesarPago(5000, 100) >= 0)
            {
                Console.WriteLine("Pago realizado");
            }
            else
            {
                Console.WriteLine("Dinero Insuficiente");
            }

            cliente.Close();
            Console.ReadKey();
        }
    }
}
