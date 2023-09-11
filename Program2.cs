using System;
using System.Security.Cryptography;

namespace lab1._2
{
    internal class Program2
    {
        private static int length=10;

        static void Main(string[] args)
        {
            var rndNumberGenerator = new RNGCryptoServiceProvider();
            var randomNumber = new byte[length];
            rndNumberGenerator.GetBytes(randomNumber);
            Console.WriteLine(Convert.ToBase64String(randomNumber));
            
        }
    }
}
