using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Enums
{
    /// <summary>
    /// Describes the type of package that will be picked/delivered
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum PackageType
    {
        /// <summary>
        /// Envelope
        /// </summary>
        [EnumMember(Value = "plic")]
        Envelope,

        /// <summary>
        /// Package
        /// </summary>
        [EnumMember(Value = "colet")]
        Package,

        /// <summary>
        /// Pallet
        /// </summary>
        [EnumMember(Value = "palet")]
        Pallet
    }
}
