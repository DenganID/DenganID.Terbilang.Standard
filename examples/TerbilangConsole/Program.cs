using System;
using DenganID.Terbilang.Standard;

namespace TerbilangConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var terbilang = new Terbilang();
            var result = terbilang.From(1500027);
            Console.WriteLine(result); // "satu juta lima ratus ribu dua puluh tujuh");
        }
    }
}