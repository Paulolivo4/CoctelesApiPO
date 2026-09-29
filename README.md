# CoctelesApiPO

Cross-platform **.NET MAUI** app that consumes the public [TheCocktailDB](https://www.thecocktaildb.com/api.php) API and lists cocktails with their picture and preparation instructions.

![C#](https://img.shields.io/badge/C%23-512BD4?style=flat-square&logo=dotnet&logoColor=white)
![.NET MAUI](https://img.shields.io/badge/.NET%208%20MAUI-512BD4?style=flat-square&logo=dotnet&logoColor=white)

## How it works

1. `CocktailServicePO` calls `search.php?s=<name>` with an `HttpClient`.
2. `Newtonsoft.Json` deserializes the response into `Cocktail` objects (`StrDrink`, `StrDrinkThumb`, `StrInstructions`).
3. `MainPage` loads the results for **"margarita"** when it appears and binds them to a `ListView` that shows the image, name and instructions.

## Tech stack

C# · .NET 8 · .NET MAUI (Android, iOS, Mac Catalyst, Windows) · Newtonsoft.Json · REST API consumption with `HttpClient`.

## Getting started

**Requirements:** the [.NET 8 SDK](https://dotnet.microsoft.com/download) with the MAUI workload (`dotnet workload install maui`) and Visual Studio 2022 or another MAUI-capable IDE.

```bash
git clone https://github.com/Paulolivo4/CoctelesApiPO.git
cd CoctelesApiPO
dotnet build -t:Run -f net8.0-android
```

Or open `CoctelesApiPO.sln` in Visual Studio and run it on an emulator or device.

## Roadmap

- [ ] Search box so the user can look up any cocktail (the query is currently hardcoded to "margarita")
- [ ] Loading and error states
- [ ] Move the API call behind an interface and add tests
