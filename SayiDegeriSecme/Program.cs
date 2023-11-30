using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SayiDegeriSecme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GirilenTekCift sayibul = new GirilenTekCift();
            bool sonuc = sayibul.TekCift(7);
            if (sonuc)
            {
                Console.WriteLine("Sayı çiftir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
        }
    }
    public class GirilenTekCift
    {
        public bool TekCift(int sayi)
        {
            if (sayi % 2 == 0) 
            {
                return true;
            }
            return false;
        }
        
    }
}
