using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CCCParser.Types;

public sealed class CCCFile
{
    [JsonPropertyName("name")]
    public string Path { get; set; }
    
    [JsonPropertyName("address")]
    public uint Address { get; set; }
    
    [JsonPropertyName("functions")]
    public List<int> Functions { get; set; } = new List<int>();
}