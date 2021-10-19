using CmdSolutions.NemoExpress.Shipping.Enums;

namespace CmdSolutions.NemoExpress.Shipping.Requests
{
    /// <summary>
    /// Describes a request for listing available services
    /// </summary>
    public class ListServicesRequest : NemoExpressRequest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="apiKey">The Api key</param>
        /// <param name="serviceType">The service type</param>
        public ListServicesRequest(string apiKey, ServiceType serviceType) : base(apiKey)
        {
            ServiceType = serviceType;
        }

        /// <summary>
        /// Gets or sets the service type
        /// </summary>
        public ServiceType ServiceType { get; set; }

        /// <inheritdoc />
        public override string ApiUrl => "list_services";
    }
}
