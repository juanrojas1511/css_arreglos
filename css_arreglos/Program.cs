using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace css_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion=Pantallas.pantallaPrincipal();
            do { 
                Console.Clear();
            switch (opcion) 
            {
                case 1:
                    opcion = Pantallas.registrar_notas();
                break;
                case 2:
                    opcion = Pantallas.not_mayor();
                break;
                case 3:
                    opcion = Pantallas.not_menor();
                break;
                case 4:
                    opcion = Pantallas.busc_nota();
                break;
                case 5:
                    opcion = Pantallas.modifi_nota();
                break;
                case 6:
                    opcion = Pantallas.not_registradas();
                break;
                case 0:
                default:
                    opcion = Pantallas.pantallaPrincipal();
                break;
            }
            } while (opcion != 7) ;


        }
    }
}
