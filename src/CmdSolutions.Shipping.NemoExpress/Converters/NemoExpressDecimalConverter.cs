using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Converters
{
    sealed class NemoExpressDecimalConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return (typeToConvert == typeof(decimal));
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(string.Format("{0:N2}", value));
        }
    }
}
