namespace CmdSolutions.NemoExpress.Shipping.Requests
{
    /// <summary>
    /// Describes a base request for the Nemo Express Api
    /// </summary>
    public abstract class NemoExpressRequest
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="apiKey">The Api Key</param>
        protected NemoExpressRequest(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Gets or sets the Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets the Api Url
        /// </summary>
        public abstract string ApiUrl { get; }
    }
}
