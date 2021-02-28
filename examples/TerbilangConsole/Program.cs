using System;
using DenganID.Terbilang.Standard;
namespace TerbilangConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Terbilang terbilang = new Terbilang();
            var result = terbilang.From(1500027);
            Console.WriteLine(result); // "satu juta lima ratus ribu dua puluh tujuh");
        }
    }
}