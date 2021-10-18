using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Response
{
    /// <summary>
    /// Describes a response status from the Nemo Express Api
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum NemoExpressResponseStatus
    {
        /// <summary>
        /// The response is ok
        /// </summary>
        [EnumMember(Value = "done")]
        Done,

        /// <summary>
        /// Not allowed? (gtfo... do proper documentation nemo)
        /// </summary>
        [EnumMember(Value = "forbidden")]
        Forbidden,

        /// <summary>
        /// The response failed somewhere over the rainbow
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed
    }
}
