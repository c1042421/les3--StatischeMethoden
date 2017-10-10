using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefStatischeMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            //Schrikkeljaar
            int jaar = 2012;
            Console.WriteLine("Schrikkeljaar is " + Schrikkeljaar.IsSchrikkeljaar(jaar));
            
            //EuroConversie
            decimal euro = 10;
            decimal frank = 200;

            string message = string.Format(
                "{0} euro ----- {1}\n" +
                "{2} bef ------ {3}",
                euro ,
                EuroConversie.ToBef(euro), 
                frank,
                EuroConversie.ToEuro(frank));

            Console.WriteLine(message);

            //Rijksregisternummer
            string rrnr = "65041523034";

            Console.WriteLine(string.Format("Rijksregister nummer is goed : {0}", Rijksregisternummer.IsValid(rrnr)));



            Console.Read();
        }
    }
}
