using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace Karavaev
{
    class MyRandom
    {
        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        public int Next(int a, int b)
        {
            byte[] randomNumber = new byte[1];
            rng.GetBytes(randomNumber);
            rng.Dispose();
            int x = (b - a + 1);
            int ans = a + (randomNumber[0] % x);
            if(x > 256 && ans % 2 == 1 && ans + 255 <= b)
            {
                ans += 255;
            }
            return ans;
        }
    }
}
