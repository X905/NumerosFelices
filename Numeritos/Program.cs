using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeritos
{
   
    /* 
     * Desarrollar una aplicación de consola que permita encontrar los numeros felices 
     * e infelices desde A hasta B [A,B] y mostrarlos en pantalla :)
     */
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string descripcion;
            Console.WriteLine("Ingrese el rango de numeros a evaluar");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B: ");
            b = Convert.ToInt32(Console.ReadLine());

            string numeroCadena;
            int length = 0;
            int result = 0;

            Console.Clear();
            //Obtener lista de numeros
            foreach(int numero in Numeros(a, b))
            {
                result =  numero;
                while (result != 1 && result != 4)
                {
                    numeroCadena = Convert.ToString(result);
                    result = 0;
                    length = numeroCadena.Length;
                    int[] n = new int[length];
                    for (int i = 0; i < length; i++)
                    {
                        n[i] = Convert.ToInt32(numeroCadena.Substring(i, 1));
                        result = result + (n[i] * n[i]);
                        if (result == 1 && length == 1)
                        {
                            i = length;
                        }
                    }
                }
                descripcion = result == 1 ? " Es un número Feliz" : " Es un número Triste";
                Console.WriteLine(numero + descripcion);
            }
            Console.ReadKey();
        }

        public static List<int> Numeros (int a, int b)
        {
            List<int> numeros = new List<int>();
            for (int i = a; i <= b; i++)
            {
                numeros.Add(a++);
            }
            return numeros;
        }
    }
}
