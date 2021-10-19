using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Enums
{
    /// <summary>
    /// Describes service types
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ServiceType
    {
        /// <summary>
        /// Main service
        /// </summary>
        [EnumMember(Value = "main")]
        Main,

        /// <summary>
        /// Extra services
        /// </summary>
        [EnumMember(Value = "extra")]
        Extra
    }
}
