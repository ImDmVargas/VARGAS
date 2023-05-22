using System;
using System.Security.Cryptography.X509Certificates;
using TIENDAVARGASANDRADE.SERVICIOS;

namespace TIENDAVARGASANDRADE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FUNCIONES funcion = new FUNCIONES();

            funcion.Bienvenida();
            funcion.Calcula();
        }
    }
}
