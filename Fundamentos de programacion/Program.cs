using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_programacion
{
    internal class Program
    {
        static void Main(string[] args) // 
        {
            //tipos de datos 
            /*int num1 = 214748364;
            uint valor1 = 0;
            int num2 = 5, num3 = 6;
            long largas = 21474836488888;
            ulong ularga = 2222;
            byte b = 255;
            sbyte s = 23;
            int? total = null;

            float flotante = 25.36f;
            double doble = 100.5d;
            decimal dec = 56.65m;
            
            bool boleana = new bool();

            // var & dynamic 
            var variable = 20.03f;
            variable = 20;

            dynamic dinamico = "Hoy es un buen dia";
            dinamico = 20.699f;
            dinamico = true;

            var persona = new { NOMBRE = "Miguel", APELLIDO = "Rios", EDAD = 30};
            Console.WriteLine($"{persona.NOMBRE}{persona.APELLIDO} {persona.EDAD}");

            string nombre = "Carolina";
            String Nombre = "Luis Carlos";
            string apellido = "Morera";
            String Apellido = "Rodriguez";
            char caracter = 'c';
           */

            /*Console.WriteLine("Digite el salario por hora:");
            Double salario = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine("Digite las horas trabajadas:");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El empleado {0} {1}  percibe un salario de: {2} colones", nombre, Apellido, (horas* salario));

            Console.WriteLine("total;"+ total + "Boleana"+ boleana);
            Console.WriteLine(nombre + " "+ apellido);
            Console.WriteLine(Nombre+ " "+ Apellido);
            //desplegar con parametros 
            Console.WriteLine("La estudiante se llama {0}{1}", nombre, Apellido);
            //desplegar con interpolacion
            Console.WriteLine($"La estudiante se llama {Nombre}{apellido}");*/




            // Contadores y acumuladores
            //int cont = 0;

            /* //            cont= cont + 1;
             Console.WriteLine(cont++);  //1
             Console.WriteLine(cont++); //2
             Console.WriteLine(cont);   //2
             //++cont;
             //cont--;// cont = cont -1
             //--cont;
            */


            float salario =0;
            /*total = 0;
            total += salario;// total = total + salario 
            total *= salario;// total =  total * salario 
            total -= salario;//total =  total - salario
            total /= salario;//total = total / salario 
            */


            //Arreglos y matrices 
            int[] edad = new int[] { 20, 22, 33 }; //arreglo de tres posiciones 
            float[] salarios = new float[] { 200, 300, 150 }; //arreglo de tres posiciones

            String[] musico = new String[3];
            musico[0] = "Ringo";
            musico[1] = " Paul";
            musico[2] = "John ";


            Console.WriteLine(musico.Length);
            //ciclo for
            for (int i = 0; i < musico.Length; i++)
            {
                float IVA = 0;
                IVA = (float)(salarios[i] * 0.13);
                Console.WriteLine($"{musico[i]} edad : {edad[i]} salario: {salarios[i]} IVA: {salarios[i]*0.13} Total {salarios[i] + IVA}");
            }


            Console.ReadLine();


        }
    }
}

