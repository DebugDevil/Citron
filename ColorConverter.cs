using Newtonsoft.Json;
using System;
using System.Drawing;

namespace Citron
{
    /// <summary>
    /// A Json.Net converter from string to Color and vice versa.
    /// </summary>
    public class ColorConverter : JsonConverter<Color>
    {
        public override Color ReadJson(JsonReader reader, Type objectType, Color existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            // Return the value from the known color
            return Color.FromKnownColor((KnownColor)Enum.Parse(typeof(KnownColor), (string)reader.Value));
        }

        public override void WriteJson(JsonWriter writer, Color value, JsonSerializer serializer)
        {
            // We don't need to write anything
            throw new NotImplementedException();
        }
    }
}
