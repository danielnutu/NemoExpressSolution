using CmdSolutions.NemoExpress.Shipping.Requests;
using CmdSolutions.NemoExpress.Shipping.Response;
using System.Threading;
using System.Threading.Tasks;

namespace CmdSolutions.NemoExpress.Shipping
{
    public interface INemoExpressClient
    {
        Task<ShipmentStatusResponse> GetStatusAsync(ShipmentStatusRequest request, CancellationToken cancellationToken);
    }
}
