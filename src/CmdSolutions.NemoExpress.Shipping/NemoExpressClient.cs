using CmdSolutions.NemoExpress.Shipping.Requests;
using CmdSolutions.NemoExpress.Shipping.Response;
using CmdSolutions.NemoExpress.Shipping.Utilities;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace CmdSolutions.NemoExpress.Shipping
{
    public class NemoExpressClient : INemoExpressClient
    {
        private readonly HttpClient _httpClient;

        public NemoExpressClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ShipmentStatusResponse> GetStatusAsync(ShipmentStatusRequest request, CancellationToken cancellationToken)
        {
            var url = request.ApiUrl;

            var queryString = QueryString
                .Create("api_key", request.ApiKey)
                .Add("awbno", request.AwbNumber);

            return await _httpClient.GetFromJsonAsync<ShipmentStatusResponse>($"{url}{queryString}", cancellationToken);
        }
    }
}
