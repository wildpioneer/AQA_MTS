using System.Text.Json.Serialization;

namespace ValueOfObjects.Models;


public class JsonObject2
{
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("value")] public int FieldValue { get; set; }
    [JsonPropertyName("enabled")] public bool IsEnabled { get; set; }
    [JsonIgnore] public object IgnoreObject { get; set; }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(FieldValue)}: {FieldValue}, {nameof(IsEnabled)}: {IsEnabled}, {nameof(IgnoreObject)}: {IgnoreObject}";
    }
}