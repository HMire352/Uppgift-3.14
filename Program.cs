using System;
namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut ur gymnasiet än?");
            string skola = Console.ReadLine().ToLower();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());
            if (skola == "j")
            {
         
            }
            else if (skola == "n")
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
            if (ålder <= 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }

            else if (ålder >= 22)
            { 
                Console.WriteLine("vi letar tyvärr efter annan personal just nu");



            }
        }
    }
}


            
            
        