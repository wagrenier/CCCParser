using System.IO;
using System.Linq;
using System.Text.Json;
using CCCParser.Types;

var cccOutput = JsonSerializer.Deserialize<CCCOutput>(File.ReadAllText("Resources/FatalFrame2.json"), new JsonSerializerOptions
{
    PropertyNameCaseInsensitive = true
});
        
using (var writer = new StreamWriter("file.csv"))
{
    writer.WriteLine("File (# Fun) / Function Name,Size (bytes),# Instructions,% Decomp,Decomp.me");
            
    foreach (var cFile in cccOutput.Files)
    {
        writer.WriteLine($"{cFile.Path} ({cFile.Functions.Count})");

        foreach (CCCFunction func in cFile.Functions.Select(funcId => cccOutput.Functions[funcId]))
        {
            writer.WriteLine($"\"{func.Name}\",{func.size},{func.size >> 2},0%,,");
        }

        writer.WriteLine();
    }
}

return 0;