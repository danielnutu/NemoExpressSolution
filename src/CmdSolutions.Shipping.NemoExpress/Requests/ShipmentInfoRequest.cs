namespace CmdSolutions.Shipping.NemoExpress.Requests
{
    /// <summary>
    /// Describes a shipment status request
    /// </summary>
    public class ShipmentInfoRequest : NemoExpressRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiKey">The Api Key</param>
        /// <param name="awbNumber">The AWB Number</param>
        public ShipmentInfoRequest(string apiKey, string awbNumber) : base(apiKey)
        {
            AwbNumber = awbNumber;
        }

        /// <summary>
        /// Gets or sets the AWB Number
        /// </summary>
        public string AwbNumber { get; set; }

        /// <inheritdoc />
        public override string ApiUrl => "get_info";
    }
}
