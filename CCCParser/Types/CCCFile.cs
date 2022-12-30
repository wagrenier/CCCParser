using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CCCParser.Types;

public sealed class CCCFile
{
    public string Path { get; set; }
    public List<CCCFunction> Functions { get; set; }

    [JsonPropertyName("global_variables")]
    public List<CCCGlobalType> GlobalVariables { get; set; }
}