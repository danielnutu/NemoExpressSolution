using CmdSolutions.NemoExpress.Shipping.Converters;
using CmdSolutions.NemoExpress.Shipping.Enums;
using System;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Response
{
    /// <summary>
    /// Describes the shipment information information (yes, double info) received from the Api
    /// </summary>
    public class ShipmentInfoDataInformationData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

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

        /// <summary>
        /// Get or sets the shipment's type
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Get or sets the shipment's service
        /// </summary>
        [JsonPropertyName("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// Get or sets the shipment's payer
        /// </summary>
        [JsonPropertyName("payer")]
        public PayerType Payer { get; set; }

        /// <summary>
        /// Get or sets the client name
        /// </summary>
        [JsonPropertyName("client_name")]
        public string ClientName { get; set; }

        /// <summary>
        /// Get or sets the client reference
        /// </summary>
        [JsonPropertyName("client_reference")]
        public string ClientReference { get; set; }

        /// <summary>
        /// Get or sets the shipment's from name
        /// </summary>
        [JsonPropertyName("from_name")]
        public string FromName { get; set; }

        /// <summary>
        /// Get or sets the shipment's from contact
        /// </summary>
        [JsonPropertyName("from_contact")]
        public string FromContact { get; set; }

        /// <summary>
        /// Get or sets the shipment's from tax identification number
        /// </summary>
        [JsonPropertyName("from_cui")]
        public string FromTaxIdentificationNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment's from trade register number
        /// </summary>
        [JsonPropertyName("from_regcom")]
        public string FromTradeRegisterNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment's from phone
        /// </summary>
        [JsonPropertyName("from_phone")]
        public string FromPhone { get; set; }

        /// <summary>
        /// Get or sets the shipment's from address
        /// </summary>
        [JsonPropertyName("from_address")]
        public string FromAddress { get; set; }

        /// <summary>
        /// Get or sets the shipment's from zip code
        /// </summary>
        [JsonPropertyName("from_zipcode")]
        public string FromZipcode { get; set; }

        /// <summary>
        /// Get or sets the shipment's from county
        /// </summary>
        [JsonPropertyName("from_county")]
        public string FromCounty { get; set; }

        /// <summary>
        /// Get or sets the shipment's from city
        /// </summary>
        [JsonPropertyName("from_city")]
        public string FromCity { get; set; }

        /// <summary>
        /// Get or sets the shipment's from country
        /// </summary>
        [JsonPropertyName("from_country")]
        public string FromCountry { get; set; }

        /// <summary>
        /// Get or sets the shipment's from time
        /// </summary>
        [JsonConverter(typeof(UnixEpochDateTimeConverter))]
        [JsonPropertyName("from_time")]
        public DateTime FromTime { get; set; }

        /// <summary>
        /// Get or sets the shipment's to name
        /// </summary>
        [JsonPropertyName("to_name")]
        public string ToName { get; set; }

        /// <summary>
        /// Get or sets the shipment's to contact
        /// </summary>
        [JsonPropertyName("to_contact")]
        public string ToContact { get; set; }

        /// <summary>
        /// Get or sets the shipment's to received by
        /// </summary>
        [JsonPropertyName("to_received_by")]
        public string ToReceivedBy { get; set; }

        /// <summary>
        /// Get or sets the shipment's to tax identification number
        /// </summary>
        [JsonPropertyName("to_cui")]
        public string ToTaxIdentificationNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment's to trade register number
        /// </summary>
        [JsonPropertyName("to_regcom")]
        public string ToTradeRegisterNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment's to phone
        /// </summary>
        [JsonPropertyName("to_phone")]
        public string ToPhone { get; set; }

        /// <summary>
        /// Get or sets the shipment's to address
        /// </summary>
        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; }

        /// <summary>
        /// Get or sets the shipment's to zip code
        /// </summary>
        [JsonPropertyName("to_zipcode")]
        public string ToZipcode { get; set; }

        /// <summary>
        /// Get or sets the shipment's to county
        /// </summary>
        [JsonPropertyName("to_county")]
        public string ToCounty { get; set; }

        /// <summary>
        /// Get or sets the shipment's to city
        /// </summary>
        [JsonPropertyName("to_city")]
        public string ToCity { get; set; }

        /// <summary>
        /// Get or sets the shipment's to country
        /// </summary>
        [JsonPropertyName("to_country")]
        public string ToCountry { get; set; }

        /// <summary>
        /// Get or sets the shipment's to time
        /// </summary>
        [JsonConverter(typeof(UnixEpochDateTimeConverter))]
        [JsonPropertyName("to_time")]
        public DateTime ToTime { get; set; }

        /// <summary>
        /// Get or sets the shipment's pickup date
        /// </summary>
        [JsonConverter(typeof(UnixEpochDateTimeConverter))]
        [JsonPropertyName("pickup_date")]
        public DateTime PickupDate { get; set; }

        /// <summary>
        /// Get or sets the shipment's schedules pickup date
        /// </summary>
        [JsonConverter(typeof(UnixEpochDateTimeConverter))]
        [JsonPropertyName("scheduled_pickup_date")]
        public DateTime ScheduledPickupDate { get; set; }

        /// <summary>
        /// Get or sets the shipment's schedules pickup interval
        /// </summary>
        [JsonPropertyName("scheduled_pickup_interval")]
        public string ScheduledPickupInterval { get; set; }

        /// <summary>
        /// Get or sets the shipment's price w/o VAT
        /// </summary>
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// Get or sets the shipment's price with VAT
        /// </summary>
        [JsonPropertyName("price_with_vat")]
        public decimal PriceWithVat { get; set; }

        /// <summary>
        /// Get or sets the shipment's weight
        /// </summary>
        [JsonPropertyName("weight")]
        public decimal Weight { get; set; }

        /// <summary>
        /// Get or sets the shipment's franchisor number
        /// </summary>
        [JsonPropertyName("franchisor_no")]
        public string FranchisorNo { get; set; }

        /// <summary>
        /// Get or sets the shipment's franchisor number canon (huh?)
        /// </summary>
        [JsonPropertyName("franchisor_no_canon")]
        public string FranchisorNoCanon { get; set; }

        /// <summary>
        /// Get or sets the shipment's franchisor type
        /// </summary>
        [JsonPropertyName("franchisor_type")]
        public string FranchisorType { get; set; }

        /// <summary>
        /// Get or sets the shipment's content
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// Get or sets the shipment's repayment
        /// </summary>
        [JsonPropertyName("ramburs")]
        public decimal Repayment { get; set; }

        /// <summary>
        /// Get or sets the shipment's repayment type
        /// </summary>
        [JsonPropertyName("ramburs_type")]
        public string RepaymentType { get; set; }

        /// <summary>
        /// Get or sets the shipment's return
        /// </summary>
        [JsonPropertyName("retur")]
        public string Retur { get; set; }

        /// <summary>
        /// Get or sets the shipment's return undelivered (huh?)
        /// </summary>
        [JsonPropertyName("retur_undelivered")]
        public string ReturUndelivered { get; set; }

        /// <summary>
        /// Get or sets the shipment's return type
        /// </summary>
        [JsonPropertyName("retur_type")]
        public string ReturType { get; set; }

        /// <summary>
        /// Get or sets the shipment's return repayment
        /// </summary>
        [JsonPropertyName("retur_ramburs")]
        public string ReturRamburs { get; set; }

        /// <summary>
        /// Get or sets the shipment's comment
        /// </summary>
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Get or sets the shipment's errors
        /// </summary>
        [JsonPropertyName("errors")]
        public string Errors { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            return $"Id: {Id}" + Environment.NewLine +
                $"Awb Number: {AwbNumber}" + Environment.NewLine +
                $"Status: {Status}" + Environment.NewLine +

                $"Type: {Type}" + Environment.NewLine +
                $"ServiceType: {ServiceType}" + Environment.NewLine +
                $"Payer: {Payer}" + Environment.NewLine +

                $"ClientName: {ClientName}" + Environment.NewLine +
                $"ClientReference: {ClientReference}" + Environment.NewLine +

                $"FromName: {FromName}" + Environment.NewLine +
                $"FromContact: {FromContact}" + Environment.NewLine +
                $"FromTaxIdentificationNumber: {FromTaxIdentificationNumber}" + Environment.NewLine +
                $"FromTradeRegisterNumber: {FromTradeRegisterNumber}" + Environment.NewLine +
                $"FromPhone: {FromPhone}" + Environment.NewLine +
                $"FromAddress: {FromAddress}" + Environment.NewLine +
                $"FromZipcode: {FromZipcode}" + Environment.NewLine +
                $"FromCounty: {FromCounty}" + Environment.NewLine +
                $"FromCity: {FromCity}" + Environment.NewLine +
                $"FromCountry: {FromCountry}" + Environment.NewLine +
                $"FromTime: {FromTime}" + Environment.NewLine +

                $"ToName: {ToName}" + Environment.NewLine +
                $"ToContact: {ToContact}" + Environment.NewLine +
                $"ToReceivedBy: {ToReceivedBy}" + Environment.NewLine +
                $"ToTaxIdentificationNumber: {ToTaxIdentificationNumber}" + Environment.NewLine +
                $"ToTradeRegisterNumber: {ToTradeRegisterNumber}" + Environment.NewLine +
                $"ToPhone: {ToPhone}" + Environment.NewLine +
                $"ToAddress: {ToAddress}" + Environment.NewLine +
                $"ToZipcode: {ToZipcode}" + Environment.NewLine +
                $"ToCounty: {ToCounty}" + Environment.NewLine +
                $"ToCity: {ToCity}" + Environment.NewLine +
                $"ToCountry: {ToCountry}" + Environment.NewLine +
                $"ToTime: {ToTime}" + Environment.NewLine +

                $"PickupDate: {PickupDate}" + Environment.NewLine +
                $"ScheduledPickupDate: {ScheduledPickupDate}" + Environment.NewLine +
                $"ScheduledPickupInterval: {ScheduledPickupInterval}" + Environment.NewLine +

                $"Price: {Price}" + Environment.NewLine +
                $"PriceWithVat: {PriceWithVat}" + Environment.NewLine +
                $"Weight: {Weight}" + Environment.NewLine +

                $"FranchisorNo: {FranchisorNo}" + Environment.NewLine +
                $"FranchisorType: {FranchisorType}" + Environment.NewLine +
                $"FranchisorNoCanon: {FranchisorNoCanon}" + Environment.NewLine +

                $"Ramburs: {Repayment}" + Environment.NewLine +
                $"RambursType: {RepaymentType}" + Environment.NewLine +

                $"Retur: {Retur}" + Environment.NewLine +
                $"ReturUndelivered: {ReturUndelivered}" + Environment.NewLine +
                $"ReturType: {ReturType}" + Environment.NewLine +
                $"ReturRamburs: {ReturRamburs}" + Environment.NewLine +

                $"Comments: {Comments}" + Environment.NewLine +
                $"Errors: {Errors}";
        }
    }
}
