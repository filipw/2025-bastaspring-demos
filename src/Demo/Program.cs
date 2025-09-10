using LibOQS.NET;
using Spectre.Console;

var demo = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Choose the [green]demo[/] to run?")
        .AddChoices(
        [
            "ML-KEM (BouncyCastle)",
                "ML-DSA (BouncyCastle)",
                "ML-KEM (Windows API)",
                "ML-DSA (Windows API)",
                "ML-KEM (LibOQS.NET)",
                "ML-DSA (LibOQS.NET)"
        ]));

switch (demo)
{
    case "ML-KEM (BouncyCastle)":
        BouncyCastleDemo.RunMlKem();
        break;
    case "ML-DSA (BouncyCastle)":
        BouncyCastleDemo.RunMldsa();
        break;
    case "ML-DSA (Windows API)":
        WindowsDemo.RunMlDsa();
        break;
    case "ML-KEM (Windows API)":
        WindowsDemo.RunMlKem();
        break;
    case "ML-KEM (LibOQS.NET)":
        LibOqsDemo.RunMlKem();
        break;
    case "ML-DSA (LibOQS.NET)":
        LibOqsDemo.RunMldsa();
        break;
    default:
        Console.WriteLine("Nothing selected!");
        break;
}

LibOqs.Cleanup();

public static class FormatExtensions
{
    public static string PrettyPrint(this byte[] bytes)
    {
        var base64 = Convert.ToBase64String(bytes);
        return base64.Length > 50 ? $"{base64[..25]}...{base64[^25..]}" : base64;
    }
}