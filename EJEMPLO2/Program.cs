using System;
using System.Threading;

namespace ejemplo_2_de_la_clase_5_progra
{
    class Program
    {
        public static string Mid(string parametro, int startIndex, int length)
        {
            string result = parametro.Substring(startIndex, length);
            return result;
        }
        static void Main(string[] args)
        {
            string NOM;
            string CAR;
            int K = 0;
            int P = 0;
            int CI = 0;
            int CF = 0;
            Console.WriteLine("Ingrese su nombre");
            NOM = Console.ReadLine();
            Console.SetCursorPosition(1,12);
            Console.Write(NOM);
            CI =  NOM.Length;
            CF = 70;
            NOM = NOM.ToUpper();

            for (P = NOM.Length; P > 1; P--) 
            {
                CAR = Mid(NOM, P - 1, 1);
                for (K = CI; K < CF; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write("  " + CAR);
                    Thread.Sleep(50);


                }

                CF = CF - 1;
                CI = CI - 1;

          
            
            }

        
        
        
        }
        
        
       
        
    }
}
