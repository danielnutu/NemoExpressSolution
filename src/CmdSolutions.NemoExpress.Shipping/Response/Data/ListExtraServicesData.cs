using System;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Response
{
    /// <summary>
    /// Describes the extra services received from the Api
    /// </summary>
    public class ListExtraServicesData
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            return $"Id: {Id}" + Environment.NewLine +
                $"Name: {Name}" + Environment.NewLine +
                $"Description: {Description}";

        }
    }
}
