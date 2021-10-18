using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Converters
{
    sealed class UnixEpochDateTimeConverter : JsonConverter<DateTime>
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0);

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var date = reader.TokenType switch
            {
                JsonTokenType.Number => _epoch.AddSeconds(reader.GetInt64()),
                JsonTokenType.String => _epoch.AddSeconds(double.Parse(reader.GetString())),
                _ => DateTime.Now
            };

            return date;
        }

        // have a look at
        // https://referencesource.microsoft.com/#System.Web.Extensions/Script/Serialization/JavaScriptSerializer.cs
        // SerializeDateTime where they use ticks
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            long unixTime = Convert.ToInt64((value - _epoch).TotalSeconds);

            string formatted = FormattableString.Invariant($"{unixTime}");
            writer.WriteStringValue(formatted);
        }
    }
}
