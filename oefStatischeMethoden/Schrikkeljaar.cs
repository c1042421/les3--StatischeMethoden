using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefStatischeMethoden
{
    class Schrikkeljaar
    {
        public static bool IsSchrikkeljaar(int jaar)
        {
            bool isDeelbaarDoor4 = jaar % 4 == 0;
            bool nietDeelbaarDoor100 = jaar % 100 != 0;
            bool deelbaarDoor400 = jaar % 400 == 0;

            return isDeelbaarDoor4  && nietDeelbaarDoor100 || deelbaarDoor400;
        }
    }
}
