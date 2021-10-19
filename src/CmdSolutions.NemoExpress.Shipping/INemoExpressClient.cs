using CmdSolutions.NemoExpress.Shipping.Requests;
using CmdSolutions.NemoExpress.Shipping.Response;
using System.Threading;
using System.Threading.Tasks;

namespace CmdSolutions.NemoExpress.Shipping
{
    /// <summary>
    /// Describes the operations that the Nemo Express Api can handle
    /// </summary>
    public interface INemoExpressClient
    {
        /// <summary>
        /// Gets the status of a shipment
        /// </summary>
        /// <param name="request">The shipment status request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The shipment status response</returns>
        Task<ShipmentStatusResponse> GetStatusAsync(ShipmentStatusRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Gets information about a shipment
        /// </summary>
        /// <param name="request">The shipment info request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The shipment info response</returns>
        Task<ShipmentInfoResponse> GetInfoAsync(ShipmentInfoRequest request, CancellationToken cancellationToken);
    }
}
