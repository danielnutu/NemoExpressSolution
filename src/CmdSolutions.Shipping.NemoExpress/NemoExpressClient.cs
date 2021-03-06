using CmdSolutions.Shipping.NemoExpress.Extensions;
using CmdSolutions.Shipping.NemoExpress.Requests;
using CmdSolutions.Shipping.NemoExpress.Response;
using CmdSolutions.Shipping.NemoExpress.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace CmdSolutions.Shipping.NemoExpress
{
    /// <inheritdoc/>
    public class NemoExpressClient : INemoExpressClient
    {
        private bool _disposedValue;
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

        /// <inheritdoc/>
        public async Task<ExpeditionPriceResponse> GetExpeditionPrice(ExpeditionPriceRequest request, CancellationToken cancellationToken)
        {
            // because the api expects a request body of content type 
            // application/x-www-form-urlencoded 
            // we need to serialize the request object's properties
            // to a key value pair

            var url = request.ApiUrl + QueryString.Create("api_key", request.ApiKey);

            // serialize object to json
            var json = JsonSerializer.Serialize(request,
                new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                });

            // deserialize json to IDictionary
            var kvp = JsonSerializer.Deserialize<IDictionary<string, string>>(json);

            var formContent = new FormUrlEncodedContent(kvp);

            var response = await _httpClient.PostAsync(url, formContent, cancellationToken);

            return await response.ReadAsync<ExpeditionPriceResponse>();
        }

        ~NemoExpressClient()
        {
            Dispose(disposing: false);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _httpClient?.Dispose();
                }

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
