using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MetodosFunciones1
{
    internal class Program
    {
        static int num1 = 7;  //Variable global
        static int num2 = 3;
        static int total = 0;
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Digite otro numero");
            num2 = int.Parse(Console.ReadLine());
            suma(num1,num2, "Anthony");
            resta(num1, num2);
            dividir (num1, num2);
            Console.WriteLine(  $"Division: {dividir(num1, num2)}" );
            Console.WriteLine($"Calcule el aguinaldo {CalculoAguinaldo(5, 500, "Felipe")}");
            float salario = CalculoAguinaldo(5,500, "Felipe")
            Console.Read();
        }

        // funciones no usan la palabra void, definen un tipo de dato, usan return


        static void Aguinaldo(int mes, float salario, string codigo)
        {
            Console.WriteLine($"Calcule el Aguinaldo total*******");
        }

        static float CalculoAguinaldo(int mes, float salario, string codigo,)
        {
            //operacion
            return 0;
        }

        static int dividir (int x , int y)
        {
            total = (x/y);
            return total;   
        }

        
        static void suma(int v1, int v2, String nombre)
        {
            Console.WriteLine($"Suma: {v1 + v2} {nombre}");
        }


        static void resta(int x, int y)
        {
         
            Console.WriteLine($"Resta: {x - y}");
        }

       
    }
}
