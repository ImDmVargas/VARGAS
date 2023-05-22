using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TIENDAVARGASANDRADE.ENTIDADES;

namespace TIENDAVARGASANDRADE.SERVICIOS
{
    public class FUNCIONES
    {
        public void Bienvenida()
        {

            AnsiConsole.Write(
            new FigletText("Bienvenido")
        .LeftJustified()
        .Color(Color.Blue));

            AnsiConsole.Status();
            AnsiConsole.Status()
    .AutoRefresh(false)
    .Spinner(Spinner.Known.Star)
    .SpinnerStyle(Style.Parse("green bold"))
    .Start("Thinking...", ctx =>
    {
        // Omitted
        ctx.Refresh();
    });

        }
        public void Calcula()
        {
            FUNCIONES funcion = new FUNCIONES();
            Cliente usuario = new Cliente();
            try
            {
            Console.WriteLine("Ingresa tu nombre: ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu apellido: ");
            usuario.Apellido = Console.ReadLine();

            DateTime horaactual = DateTime.Now;

            Console.WriteLine("Ingresa la cantidad total de la compra: ");
            double monto = double.Parse(Console.ReadLine());
                bool bandera = false;
                if (monto >= 5000 && monto <=7999)
                {
                    double actual = monto * 0.10;
                    double totaldesc = monto - actual;
                    Console.WriteLine($"Felicidades {usuario.Nombre} haz obtenido descuento de 10%:");
                    Console.WriteLine(totaldesc);
                    bandera = true;
                    funcion.continua();
                }
               if (monto >= 8000 && monto <= 9999 && bandera == false)
                {
                    Console.WriteLine($"Felicidades {usuario.Nombre} tu compra aplica a 3 meses sin intereses:");
                    Console.WriteLine("El monto a pagar sin interes es de : ");
                    double meses = monto / 3;
                    Console.WriteLine(meses);
                    bandera = true;
                    funcion.continua();
                }
                if (monto >= 10000 && bandera == false)
                {
                    Console.WriteLine($"Felicidades {usuario.Nombre}tu compra aplica a 6 o 12 meses sin intereses");
                    Console.WriteLine("¿Cuantos meses quieres 6 o 12?");
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion==6)
                    {
                        double seismeses = monto / 6;
                        Console.WriteLine("El monto a pagar sin interes es de : ");
                        Console.WriteLine(seismeses);
                    }
                    if (opcion ==12)
                    {
                        double docemeses = monto / 12;
                        Console.WriteLine("El monto a pagar sin interes es de : ");
                        Console.WriteLine(docemeses);
                    }
                    bandera = true;
                    funcion.continua();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Numero incorrecto'{e}'");
            }




        }

        public void continua()
        {
            FUNCIONES funcion = new FUNCIONES();
            Console.WriteLine("Deseas continuar: 1 si 2 salir: ");
            int opcion= int.Parse(Console.ReadLine());
            if (opcion== 1)
            {
                Console.Clear();

                funcion.Bienvenida();
                funcion.Calcula();
            }
            else
            {
                Console.WriteLine("Hasta pronto");
                Environment.Exit(0);
            }
        }


    }
}
