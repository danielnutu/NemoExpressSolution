using System;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Response
{
    /// <summary>
    /// Describes the main services received from the Api
    /// </summary>
    public class ListMainServicesData
    {
        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            return $"Name: {Name}" + Environment.NewLine +
                $"Value: {Value}";

        }
    }
}
