using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Process_kill
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string uygulamaadi;
            Console.Write("Kapatmak istediğiniz programın adını giriniz: ");
            uygulamaadi = Console.ReadLine();
           
            Process[] programkapat = Process.GetProcessesByName(uygulamaadi);
            if (programkapat.Length > 0)
            {
                foreach (Process p in programkapat)
                {
                    p.Kill();
                }
                Console.WriteLine("Kapatmak istediğiniz program kapatıldı.");
            }
            else
            {
                Console.WriteLine("Böyle bir program çalışmamaktadır.");
            }
            Console.ReadKey();
        }
    }
}
