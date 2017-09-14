using System;
using Newtonsoft.Json;

namespace WriteDown {
    public class StringHexConverter : JsonConverter{
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            if (value is int) {
                var intValue = (int) value;
                var hex = "0x" + intValue.ToString("X");
                writer.WriteValue(hex);
            } else writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if (reader.TokenType == JsonToken.Null) return 0;
            if (reader.TokenType == JsonToken.String) {
                var value = reader.Value.ToString();
                if (value.StartsWith("0x")) value = value.Substring(2);
                return int.Parse(value, System.Globalization.NumberStyles.HexNumber);
            } else if (reader.TokenType == JsonToken.Integer) return int.Parse(reader.Value.ToString());
            else return 0;
        }

        public override bool CanConvert(Type objectType) =>
            objectType is int || objectType.FullName == "System.Int32";
    }
}