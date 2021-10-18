using CmdSolutions.NemoExpress.Shipping.Converters;
using CmdSolutions.NemoExpress.Shipping.Enums;
using System;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Response
{
    /// <summary>
    /// Describes the shipment status received from the Api
    /// </summary>
    public class ShipmentStatusData
    {
        /// <summary>
        /// Get or sets the date and time
        /// </summary>
        [JsonConverter(typeof(UnixEpochDateTimeConverter))]
        [JsonPropertyName("date")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Get or sets the awb number
        /// </summary>
        [JsonPropertyName("no")]
        public string AwbNumber { get; set; }

        /// <summary>
        /// Get or sets the code
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// Get or sets the code name
        /// </summary>
        [JsonPropertyName("code_name")]
        public string CodeName { get; set; }

        /// <summary>
        /// Get or sets the location
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Get or sets the shipment status
        /// </summary>
        [JsonPropertyName("status")]
        public ShipmentStatus Status { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            return $"Date: {Date}" + Environment.NewLine +
                $"Awb Number: {AwbNumber}" + Environment.NewLine +
                $"Code: {Code}" + Environment.NewLine +
                $"Code Name: {CodeName}" + Environment.NewLine +
                $"Location: {Location}" + Environment.NewLine +
                $"Status: {Status}";
        }
    }
}
