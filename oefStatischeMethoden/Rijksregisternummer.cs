using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefStatischeMethoden
{
    class Rijksregisternummer
    {
        public static bool IsValid(string rrnr)
        {
            int eerste9Getallen = int.Parse(rrnr.Substring(0, 9));
            int controleGetal = int.Parse(rrnr.Substring(rrnr.Length - 2, 2));

            int rest = eerste9Getallen % 97;
            int uitkomst = 97 - rest;

            return uitkomst == controleGetal;
        }
    }
}
