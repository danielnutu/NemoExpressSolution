using CmdSolutions.Shipping.NemoExpress.Requests;
using CmdSolutions.Shipping.NemoExpress.Response;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CmdSolutions.Shipping.NemoExpress
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
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>The shipment status response</returns>
        Task<ShipmentStatusResponse> GetStatusAsync(ShipmentStatusRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Gets information about a shipment
        /// </summary>
        /// <param name="request">The shipment info request</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns>The shipment info response</returns>
        Task<ShipmentInfoResponse> GetInfoAsync(ShipmentInfoRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Gets a list of main services
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns></returns>
        Task<IEnumerable<ListMainServicesData>> ListMainServicesAsync(ListServicesRequest request, CancellationToken cancellationToken);

        /// <summary>
        /// Gets a list of extra services
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">The cancellation token</param>
        /// <returns></returns>
        Task<IEnumerable<ListExtraServicesData>> ListExtraServicesAsync(ListServicesRequest request, CancellationToken cancellationToken);
    }
}
