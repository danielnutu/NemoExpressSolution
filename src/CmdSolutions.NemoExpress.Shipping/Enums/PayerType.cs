using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CmdSolutions.NemoExpress.Shipping.Enums
{
    /// <summary>
    /// Describes who pays the cost of transport for this shipment
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum PayerType
    {
        /// <summary>
        /// If the payment will be made by the contracted client, usually on a monthly invoice (Default value)
        /// </summary>
        [EnumMember(Value = "client")]
        Client,

        /// <summary>
        /// If the payment is made in cash by the sender
        /// </summary>
        [EnumMember(Value = "sender")]
        Sender,

        /// <summary>
        /// If the payment is made in cash by the recipient
        /// </summary>
        [EnumMember(Value = "recipient")]
        Recipient
    }
}
