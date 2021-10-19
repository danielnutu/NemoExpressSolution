using CmdSolutions.NemoExpress.Shipping.Requests;
using CmdSolutions.NemoExpress.Shipping.Response;
using CmdSolutions.NemoExpress.Shipping.Utilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CmdSolutions.NemoExpress.Shipping
{
    /// <inheritdoc/>
    public class NemoExpressClient : INemoExpressClient
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpClient">The http client</param>
        public NemoExpressClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public async Task<ShipmentStatusResponse> GetStatusAsync(ShipmentStatusRequest request, CancellationToken cancellationToken)
        {
            var url = request.ApiUrl;

            var queryString = QueryString
                .Create("api_key", request.ApiKey)
                .Add("awbno", request.AwbNumber);

            return await _httpClient.GetFromJsonAsync<ShipmentStatusResponse>($"{url}{queryString}", cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<ShipmentInfoResponse> GetInfoAsync(ShipmentInfoRequest request, CancellationToken cancellationToken)
        {
            var url = request.ApiUrl;

            var queryString = QueryString
                .Create("api_key", request.ApiKey)
                .Add("awbno", request.AwbNumber);

            return await _httpClient.GetFromJsonAsync<ShipmentInfoResponse>($"{url}{queryString}", cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<ListMainServicesData>> ListMainServicesAsync(ListServicesRequest request, CancellationToken cancellationToken)
        {
            var url = request.ApiUrl;

            var queryString = QueryString
                .Create("api_key", request.ApiKey)
                .Add("type", request.ServiceType.ToString().ToLower());

            return await _httpClient.GetFromJsonAsync<IEnumerable<ListMainServicesData>>($"{url}{queryString}", cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<ListExtraServicesData>> ListExtraServicesAsync(ListServicesRequest request, CancellationToken cancellationToken)
        {
            var url = request.ApiUrl;

            var queryString = QueryString
                .Create("api_key", request.ApiKey)
                .Add("type", request.ServiceType.ToString().ToLower());

            return await _httpClient.GetFromJsonAsync<IEnumerable<ListExtraServicesData>>($"{url}{queryString}", cancellationToken);
        }
    }
}
