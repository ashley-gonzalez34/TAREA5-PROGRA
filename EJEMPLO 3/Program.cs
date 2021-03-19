using System;
using System.Threading;

namespace EJEMPLO_3
{
    class Program

    {
        public static string GeneraLetra()
        {

            Random ran = new Random();
            int NUM = Convert.ToInt32(ran.Next(200));
            string respuesta = "";
            
            if (((NUM > 97) & (NUM < 206)))
            {
                respuesta = Convert.ToString((char)NUM);
            }
            return respuesta;

        }
        static void Main(string[] args)
        {
            byte CAN, K;
           
            string linea;
            Console.WriteLine("Cuantos numeros :");
            linea = Console.ReadLine();
            CAN = byte.Parse(linea);
            string letras = "";


            for (K = 1; K < CAN; K++)
            {
                letras = GeneraLetra();
                Console.WriteLine($"El codigo es : {letras}");
            }
                




        }

          
        
    }
}
