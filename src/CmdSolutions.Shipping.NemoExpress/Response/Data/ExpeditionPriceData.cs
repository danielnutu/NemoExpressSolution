using System;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Response
{
    /// <summary>
    /// Describes the expedition price received from the Api
    /// </summary>
    public class ExpeditionPriceData
    {
        /// <summary>
        /// Gets or sets the zone
        /// </summary>
        [JsonPropertyName("zone")]
        public string Zone { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            return $"Zone: {Zone}" + Environment.NewLine +
                $"Price: {Price}";
        }
    }
}
