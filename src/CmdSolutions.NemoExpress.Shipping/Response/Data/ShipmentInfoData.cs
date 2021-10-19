﻿using CmdSolutions.NemoExpress.Shipping.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CmdSolutions.NemoExpress.Shipping.Response
{
    /// <summary>
    /// Describes the shipment information received from the Api
    /// </summary>
    public class ShipmentInfoData
    {
        /// <summary>
        /// Get or sets the awb number
        /// </summary>
        [JsonPropertyName("no")]
        public string AwbNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment status
        /// </summary>
        [JsonPropertyName("status")]
        public ShipmentStatus Status { get; set; }

        [JsonPropertyName("info")]
        public ShipmentInfoDataInformationData Information { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            return $"Awb Number: {AwbNumber}" + Environment.NewLine +
                $"Status: {Status}" + Environment.NewLine +
                "Information: " + Environment.NewLine +
                Information.ToString();

        }
    }
}
