using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace css_arreglos
{
    public class Pantallas
    { 
        public static float[] not = new float[50];
        public static int contador = 0;
        public static int pantallaPrincipal()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Casos con arreglos");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar notas");
            Console.WriteLine("2: Hallar la nota mayor");
            Console.WriteLine("3: Hallar la nota menor");
            Console.WriteLine("4: Encontrar una nota");
            Console.WriteLine("5: Modificar una nota ");
            Console.WriteLine("6: Ver notas registradas");
            Console.WriteLine("7: Salir");
            Console.WriteLine("================================");
            return Operaciones.getEntero("Ingrese una opción:");
        }
        public static int registrar_notas()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Registrar una nota");
            Console.WriteLine("================================");
            float notas = Operaciones.getDecimal("Ingrese la nota Nro1:");
            if (contador == 50)
            {
                Console.WriteLine("La lista esta llena");
            }
            not[contador] = notas;
            contador++;

            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar otra nota");
            Console.WriteLine("2: Regresar");
            int opcion= Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 2) return 0;
            return opcion;

        }
        public static int not_mayor()
        {
            Console.WriteLine("================================");
            Console.WriteLine("La nota mayor");
            Console.WriteLine("================================");
            string notamayor=Operaciones.getTextoPantalla("La nota mayor es: ");

            for (int i =0; i < contador; i++)
            {
                Console.WriteLine(i + "" + not[i]);
            }
            Console.WriteLine("================================");


            Console.WriteLine("1: Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int not_menor()
        {
            Console.WriteLine("================================");
            Console.WriteLine("La nota menor");
            Console.WriteLine("================================");
            Console.WriteLine("La nota menor es: ");
            Console.WriteLine("================================");

            Console.WriteLine("1: Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int busc_nota()
        {
            Console.WriteLine("================================");
            Console.WriteLine("La nota menor");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese la nota a buscar:");
            Console.WriteLine("La nota está en la posición:");




            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int modifi_nota()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Modificar nota");
            Console.WriteLine("================================");
            Console.WriteLine("Ingrese la posición:");
            Console.WriteLine("Ingrese el nuevo valor:");
            Console.WriteLine("================================");
            Console.WriteLine("Antes:");

            Console.WriteLine("Después:");

            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int not_registradas()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Notas Registradas");
            Console.WriteLine("================================");
            Console.WriteLine("Notas actuales");

            Console.WriteLine("Siguiente posición será:");

            Console.WriteLine("================================");
            Console.WriteLine("1:Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}
