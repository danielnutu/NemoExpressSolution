using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Enums
{
    /// <summary>
    /// Describes a shipment status
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ShipmentStatus
    {
        /// <summary>
        /// Draft
        /// </summary>
        [EnumMember(Value = "initial")]
        Draft,

        /// <summary>
        /// Uncollected
        /// </summary>
        [EnumMember(Value = "neridicat")]
        Uncollected,

        /// <summary>
        /// Active
        /// </summary>
        [EnumMember(Value = "in_curs")]
        Active,

        /// <summary>
        /// Delivered
        /// </summary>
        [EnumMember(Value = "livrat")]
        Delivered,

        /// <summary>
        /// Returned
        /// </summary>
        [EnumMember(Value = "returnat")]
        Returned,

        /// <summary>
        /// Canceled
        /// </summary>
        [EnumMember(Value = "anulat")]
        Canceled,

        /// <summary>
        /// Exception
        /// </summary>
        [EnumMember(Value = "exceptie")]
        Exception
    }
}
