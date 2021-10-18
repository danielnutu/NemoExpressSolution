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
        [EnumMember(Value = "done")]
        Done,

        [EnumMember(Value = "forbidden")]
        Forbidden,

        [EnumMember(Value = "failed")]
        Failed
    }
}
