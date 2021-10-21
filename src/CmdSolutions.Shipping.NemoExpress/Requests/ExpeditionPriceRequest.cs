using CmdSolutions.Shipping.NemoExpress.Converters;
using CmdSolutions.Shipping.NemoExpress.Enums;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Requests
{
    /// <summary>
    /// Describes an expedition price request
    /// </summary>
    public class ExpeditionPriceRequest : NemoExpressRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="apiKey">The Api key</param>
        public ExpeditionPriceRequest(string apiKey) : base(apiKey)
        {
        }

        /// <summary>
        /// Get or sets the shipment's type
        /// </summary>
        [JsonPropertyName("type")]
        public PackageType Type { get; set; }

        /// <summary>
        /// Get or sets the shipment's service
        /// </summary>
        [JsonPropertyName("service_type")]
        public ServiceType ServiceType { get; set; }

        /// <summary>
        /// Get or sets the shipment's return
        /// </summary>
        [JsonPropertyName("retur")]
        public string Retur { get; set; }

        /// <summary>
        /// Get or sets the shipment's return type
        /// </summary>
        [JsonPropertyName("retur_type")]
        public string ReturType { get; set; }

        /// <summary>
        /// Get or sets the shipment's repayment
        /// </summary>
        [JsonPropertyName("ramburs")]
        [JsonConverter(typeof(NemoExpressDecimalConverter))]

        public decimal CashOnDelivery { get; set; }

        /// <summary>
        /// Get or sets the shipment's repayment type
        /// </summary>
        [JsonPropertyName("ramburs_type")]
        public CashOnDeliveryType CashOnDeliveryType { get; set; }

        /// <summary>
        /// Get or sets the shipment's insured value
        /// </summary>
        [JsonPropertyName("insurance")]
        public string InsuredValue { get; set; }

        /// <summary>
        /// Get or sets the shipment's payer
        /// </summary>
        [JsonPropertyName("payer")]
        public PayerType? Payer { get; set; }

        /// <summary>
        /// Get or sets the shipment's weight
        /// </summary>
        [JsonPropertyName("weight")]
        [JsonConverter(typeof(NemoExpressDecimalConverter))]
        public decimal Weight { get; set; }

        /// <summary>
        /// Get or sets the shipment's weight
        /// </summary>
        [JsonPropertyName("length")]
        public decimal? Length { get; set; }

        /// <summary>
        /// Get or sets the shipment's weight
        /// </summary>
        [JsonPropertyName("width")]
        public decimal? Width { get; set; }

        /// <summary>
        /// Get or sets the shipment's weight
        /// </summary>
        [JsonPropertyName("height")]
        public decimal? Height { get; set; }

        /// <summary>
        /// Get or sets the shipment's content
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// Get or sets the shipment's comment
        /// </summary>
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or sets the number of packages/envelopes
        /// </summary>
        /// <remarks>
        /// Expeditions with the "cnt" set to values over 1 will be automatically converted to groups.
        /// You will receive in the response the number of the first package in the group (like "XXX"), and the rest are created as such:
        /// 1st package: XXX
        /// 2nd package: XXX/2
        /// 3rd package: XXX/3
        /// And so on.
        /// </remarks>
        [JsonPropertyName("cnt")]
        [JsonConverter(typeof(NemoExpressIntConverter))]
        public int PackageCount { get; set; }

        /// <summary>
        /// Gets or sets the customer reference (eg. order number)
        /// </summary>
        [JsonPropertyName("customer_reference")]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets if the expedition is fragile
        /// </summary>
        [JsonPropertyName("fragile")]
        public bool? Fragile { get; set; }

        /// <summary>
        /// Gets or sets the transport price to be used for this shipment
        /// </summary>
        /// <remarks>
        /// Requires the permission field_custom_price to be granted to the API Key user
        /// </remarks>
        [JsonPropertyName("custom_price")]
        public decimal? CustomPrice { get; set; }

        /// <summary>
        /// Get or sets if the default 'From Address' will be the one set in the client account
        /// </summary>
        [JsonPropertyName("use_default_from_address")]
        public bool? UseDefaultFromAddress { get; set; }

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
        /// Get or sets the shipment's from address
        /// </summary>
        [JsonPropertyName("from_address")]
        public string FromAddress { get; set; }

        /// <summary>
        /// Get or sets the shipment's from street
        /// </summary>
        [JsonPropertyName("from_str")]
        public string FromStreet { get; set; }

        /// <summary>
        /// Get or sets the shipment's from street number
        /// </summary>
        [JsonPropertyName("from_nr")]
        public string FromNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment's from building number
        /// </summary>
        [JsonPropertyName("from_bl")]
        public string FromBuilding { get; set; }

        /// <summary>
        /// Get or sets the shipment's from building entrace
        /// </summary>
        [JsonPropertyName("from_sc")]
        public string FromEntrance { get; set; }

        /// <summary>
        /// Get or sets the shipment's from apartment floor
        /// </summary>
        [JsonPropertyName("from_et")]
        public string FromFloor { get; set; }

        /// <summary>
        /// Get or sets the shipment's from apartment number
        /// </summary>
        [JsonPropertyName("from_ap")]
        public string FromApartment { get; set; }

        /// <summary>
        /// Get or sets the shipment's from entrance
        /// </summary>
        [JsonPropertyName("from_interfon")]
        public string FromIntercom { get; set; }

        /// <summary>
        /// Get or sets the shipment's from district
        /// </summary>
        [JsonPropertyName("from_sector")]
        public string FromDistrict { get; set; }

        /// <summary>
        /// Get or sets the shipment's from city
        /// </summary>
        [JsonPropertyName("from_city")]
        public string FromCity { get; set; }

        /// <summary>
        /// Get or sets the shipment's from county
        /// </summary>
        [JsonPropertyName("from_county")]
        public string FromCounty { get; set; }

        /// <summary>
        /// Get or sets the shipment's from country
        /// </summary>
        [JsonPropertyName("from_country")]
        public string FromCountry { get; set; }

        /// <summary>
        /// Get or sets the shipment's from zip code
        /// </summary>
        [JsonPropertyName("from_zipcode")]
        public string FromZipcode { get; set; }

        /// <summary>
        /// Get or sets the shipment's from email
        /// </summary>
        [JsonPropertyName("from_email")]
        public string FromEmail { get; set; }

        /// <summary>
        /// Get or sets the shipment's from phone
        /// </summary>
        [JsonPropertyName("from_phone")]
        public string FromPhone { get; set; }

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
        /// Get or sets the shipment's to address
        /// </summary>
        [JsonPropertyName("to_address")]
        public string ToAddress { get; set; }

        /// <summary>
        /// Get or sets the shipment's to street
        /// </summary>
        [JsonPropertyName("to_str")]
        public string ToStreet { get; set; }

        /// <summary>
        /// Get or sets the shipment's to street number
        /// </summary>
        [JsonPropertyName("to_nr")]
        public string ToNumber { get; set; }

        /// <summary>
        /// Get or sets the shipment's to building number
        /// </summary>
        [JsonPropertyName("to_bl")]
        public string ToBuilding { get; set; }

        /// <summary>
        /// Get or sets the shipment's to building entrace
        /// </summary>
        [JsonPropertyName("to_sc")]
        public string ToEntrance { get; set; }

        /// <summary>
        /// Get or sets the shipment's to apartment floor
        /// </summary>
        [JsonPropertyName("to_et")]
        public string ToFloor { get; set; }

        /// <summary>
        /// Get or sets the shipment's to apartment number
        /// </summary>
        [JsonPropertyName("to_ap")]
        public string ToApartment { get; set; }

        /// <summary>
        /// Get or sets the shipment's to entrance
        /// </summary>
        [JsonPropertyName("to_interfon")]
        public string ToIntercom { get; set; }

        /// <summary>
        /// Get or sets the shipment's to district
        /// </summary>
        [JsonPropertyName("to_sector")]
        public string ToDistrict { get; set; }

        /// <summary>
        /// Get or sets the shipment's to city
        /// </summary>
        [JsonPropertyName("to_city")]
        public string ToCity { get; set; }

        /// <summary>
        /// Get or sets the shipment's to county
        /// </summary>
        [JsonPropertyName("to_county")]
        public string ToCounty { get; set; }

        /// <summary>
        /// Get or sets the shipment's to country
        /// </summary>
        [JsonPropertyName("to_country")]
        public string ToCountry { get; set; }

        /// <summary>
        /// Get or sets the shipment's to zip code
        /// </summary>
        [JsonPropertyName("to_zipcode")]
        public string ToZipcode { get; set; }

        /// <summary>
        /// Get or sets the shipment's to email
        /// </summary>
        [JsonPropertyName("to_email")]
        public string ToEmail { get; set; }

        /// <summary>
        /// Get or sets the shipment's to phone
        /// </summary>
        [JsonPropertyName("to_phone")]
        public string ToPhone { get; set; }

        /// <summary>
        /// Get or sets the shipment's to extra
        /// </summary>
        [JsonPropertyName("to_extra")]
        public string ToExtra { get; set; }

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

        /// <inheritdoc />
        [JsonIgnore]
        public override string ApiUrl => "get_price";
    }
}
