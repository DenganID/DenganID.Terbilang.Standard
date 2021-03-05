# Terbilang Standard
[![NuGet version (DenganID.Terbilang.Standard)](https://img.shields.io/nuget/v/DenganID.Terbilang.Standard.svg?style=flat)](https://www.nuget.org/packages/DenganID.Terbilang.Standard/)
[![.NET](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/dotnet.yml/badge.svg)](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/dotnet.yml)
[![Unit Tests](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/unittests.yml/badge.svg)](https://github.com/DenganID/DenganID.Terbilang.Standard/actions/workflows/unittests.yml)
## Synopsis
Terbilang (netstandard2.0) is C# library for converting numeric into words in Bahasa.

## Code Example

### Console App
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

### Web App
Startup.cs

```
public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "WebApi", Version = "v1"}); });

    services.AddTransient<ITerbilang, Terbilang>();
}
```

YourController.cs
```
private readonly ITerbilang _terbilang;

public YourController(ITerbilang terbilang)
{
    _terbilang = terbilang;
}


[HttpGet("{number}")]
public IActionResult YourMethod(long number)
{
    var hasil = _terbilang.From(number);
    return Ok(hasil);
}
```
## Installation
### Package Manager
```
Install-Package DenganID.Terbilang.Standard -Version 1.0.0
```

### Dotnet CLI
```
dotnet add package DenganID.Terbilang.Standard
```

### PackageReference
```
<PackageReference Include="DenganID.Terbilang.Standard" Version="1.0.0" />
```
## Contributors
[List of contribution](https://github.com/DenganID/DenganID.Terbilang.Standard/graphs/contributors)

You can always contribute to this package and create pull requests. Just give me a note

## License

This package is released under the MIT License (MIT). Please read [LICENSE.md](https://github.com/DenganID/DenganID.Terbilang.Standard/LICENSE.md)
