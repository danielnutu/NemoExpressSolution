using System;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Response
{
    /// <summary>
    /// Describes a base response from the Nemo Express Api
    /// </summary>
    /// <typeparam name="TData">Data to be sent</typeparam>
    public abstract class NemoExpressResponse<TData> where TData : class, new()
    {
        /// <summary>
        /// Gets or sets the received data
        /// </summary>
        [JsonPropertyName("data")]
        public TData Data { get; set; }

        /// <summary>
        /// Gets or sets the returned message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the error, if any
        /// </summary>
        /// <remarks>
        /// No documentation found. Need to investigate further?
        /// </remarks>
        [JsonPropertyName("error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets the status of the response received from the Nemo Express Api
        /// </summary>
        /// <remarks>
        /// Having a status means that the request succeeded, but an error was thrown on the Api side
        /// </remarks>
        [JsonPropertyName("status")]
        public NemoExpressResponseStatus Status { get; set; }

        /// <summary>
        /// To String
        /// </summary>
        /// <returns>A string, duh!</returns>
        public override string ToString()
        {
            var message = $"{Status}: ";

            if (!string.IsNullOrWhiteSpace(Error))
            {
                message += $"{Error}: ";
            }

            message += $"{Message}" + Environment.NewLine;

            if (Status == NemoExpressResponseStatus.Done)
                message += Data.ToString();

            return message + Environment.NewLine + Environment.NewLine;
        }
    }
}
