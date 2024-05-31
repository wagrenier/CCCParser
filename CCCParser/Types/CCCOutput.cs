using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CCCParser.Types;

public sealed class CCCOutput
{
    [JsonPropertyName("source_files")]
    public List<CCCFile> Files { get; set; }
    
    [JsonPropertyName("functions")]
    public List<CCCFunction> Functions { get; set; }
    
    [JsonPropertyName("global_variables")]
    public List<CCCGlobalType> GlobalVariables { get; set; }
}