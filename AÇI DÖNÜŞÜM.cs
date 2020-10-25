using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EĞİTİM
{



    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" DERECE GİRİNİZ");
            float x = Convert.ToInt32(Console.ReadLine());

            float Radyan = (x / 180);

            Console.WriteLine("Radyan cinsinden = " + Radyan);

            Console.ReadKey();

            float Gradyan = (x / 180) * 200;

            Console.WriteLine("Gradyan cinsinden = " + (Gradyan));
           
            Console.ReadKey();
        }
      

    }
}
        
    



        