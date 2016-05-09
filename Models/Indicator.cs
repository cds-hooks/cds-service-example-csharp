using System;
using Newtonsoft.Json;

namespace org.cdshooks.example.Models
{
    [JsonConverter(typeof(IndicatorConverter))]
    public class Indicator
    {
        public static Indicator Success
        {
            get { return new Indicator("success"); }
        }

        public static Indicator Info
        {
            get { return new Indicator("info"); }
        }

        public static Indicator Warning
        {
            get { return new Indicator("warning"); }
        }

        public static Indicator HardStop
        {
            get { return new Indicator("hard-stop"); }
        }
        private Indicator(string value)
        {
            Value = value;
        }

        public string Value { get; internal set; }

        public override string ToString()
        {
            return Value;
        }
    }

    class IndicatorConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var indicator = (Indicator)value;
            writer.WriteValue(indicator.Value);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var indicator = (string)reader.Value;
            switch (indicator)
            {
                case "success":
                    return Indicator.Success;
                case "info":
                    return Indicator.Info;
                case "warning":
                    return Indicator.Warning;
                case "hard-stop":
                    return Indicator.HardStop;
            }
            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Indicator);
        }
    }
}
