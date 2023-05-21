using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Receitaws.API.Client.Converters;

public class CustomDateTimeConverter : JsonConverter<DateTime>
{
    private const string DateFormat = "dd/MM/yyyy";

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String) return default;
        
        var dateString = reader.GetString();
        
        return DateTime.TryParseExact(dateString, DateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime result) ? result : default;
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(DateFormat));
    }
}