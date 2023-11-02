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
            if (contador == 0)
            {
                Console.WriteLine("No hay notas registradas.");
                return 0; 
            }

         
            float max_not = not[0];
            for (int i = 1; i < contador; i++)
            {
                if (not[i] > max_not)
                {
                    max_not = not[i];
                }
            }
            Console.WriteLine("La nota mayor es: "+max_not);

            for (int i =0; i < contador; i++)
            {
                if (not[i] == max_not)
                {
                    Console.Write($"[{not[i]}] ");
                }
                else
                {
                    Console.Write(not[i]  + " ");
                }
            }
            Console.WriteLine();
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
          if (contador == 0)
            {
                Console.WriteLine("No hay notas registradas.");
                return 0; 
            }

            float min_not = not[0];
            for (int i = 1; i < contador; i++)
            {
                if (not[i] < min_not)
                {
                    min_not = not[i];
                }
            }
            Console.WriteLine("La nota menor es: " + min_not);

            for (int i = 0; i < contador; i++)
            {
                if (not[i] == min_not)
                {
                    Console.Write($"[{not[i]}]");
                }
                else
                {
                    Console.Write(not[i]  + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("1: Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
        public static int busc_nota()
        {
           Console.WriteLine("================================");
            Console.WriteLine("Buscar nota");
            Console.WriteLine("================================");
            float notaBuscada=Operaciones.getDecimal("Ingrese la nota a buscar:");
            bool encontrar = false;

         
            for (int i = 0; i < contador; i++)
            {
                if (not[i] ==notaBuscada)
                {
                    if (!encontrar)
                    {
                        Console.Write("La nota está en la posición:");
                        encontrar = true;
                    }
                    Console.Write($" {i} ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < contador; i++)
            {
              
                if (not[i] == notaBuscada)
                {
                    Console.WriteLine(i+"->"+$"[{not[i]}]");
                }
                else
                {
                    Console.WriteLine(i+"->"+not[i]);
                }
            }
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
            int posicion=Operaciones.getEntero("Ingrese la posición:");
            float nuevo_valor=Operaciones.getDecimal("Ingrese el nuevo valor:");
            Console.WriteLine("================================");
            Console.WriteLine("Antes:");
            for (int i = 0; i < contador; i++)
            {
                if (i == posicion)
                {
                    Console.Write($"[{not[i]}] ");
                }
                else
                {
                    Console.Write(not[i] + " ");
                }
            }
            not[posicion] = nuevo_valor;
            Console.WriteLine("\nDespués:");
            for (int i = 0; i < contador; i++)
            {
                if (i == posicion)
                {
                    Console.Write($"[{not[i]}] ");
                }
                else
                {
                    Console.Write(not[i] + " ");
                }
            }
            Console.WriteLine();
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
            for (int i = 0; i < contador; i++)
            {
                if (i != contador - 1)
                {
                    Console.Write(not[i] + " - ");
                }
                else
                {
                    Console.Write(not[i]);
                }
            }
            Console.WriteLine();
            int siguientePosicion = contador;
            Console.WriteLine("\nSiguiente posición será: " + siguientePosicion);
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("1:Regresar");
            int opcion = Operaciones.getEntero("Ingresa una opción: ");
            if (opcion == 1) return 0;
            return opcion;
        }
    }
}
