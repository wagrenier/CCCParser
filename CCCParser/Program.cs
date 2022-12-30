using System;
using System.IO;
using System.Text.Json;
using CCCParser.Types;

namespace CCCParser;

public class Program
{
    public static void Main(string[] args)
    {
        var j = JsonSerializer.Deserialize<CCCOutput>(File.ReadAllText("Resources/FatalFrame2.json"), new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        foreach (var cFile in j.Files)
        {
            Console.WriteLine(cFile.Path);
        }
    }
}