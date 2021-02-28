# Terbilang Standard
[![.NET](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/dotnet.yml/badge.svg)](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/dotnet.yml)
[![Unit Tests](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/unittests.yml/badge.svg)](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/unittests.yml)
## Synopsis
Terbilang (netstandard2.0) is C# library for converting numeric into words in Bahasa.

## Code Example
```
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
```

## Installation

dotnet add package DenganID.Terbilang.Standard

## Contributors

You can always contribute to this package and create pull requests. Just give me a note

## License

This package is released under the MIT License (MIT). Please read [LICENSE.md](https://github.com/DenganID/DenganID.Terbilang.Standard/LICENSE.md)