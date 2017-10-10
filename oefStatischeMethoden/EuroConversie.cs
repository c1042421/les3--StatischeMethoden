using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefStatischeMethoden
{
    class EuroConversie
    {
        private static decimal _koers = (decimal)40.3399;

        public static decimal Koers
        {
            get { return _koers; }
            set { _koers = value; }
        }

        public static decimal ToBef(decimal amount)
        {
            return amount * Koers;
        }

        public static decimal ToEuro(decimal amount)
        {
            return amount / Koers;
        }
    }
}
