using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CmdSolutions.Shipping.NemoExpress.Enums
{
    /// <summary>
    /// Describes the types of cash on delivery payment
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum CashOnDeliveryType
    {
        /// <summary>
        /// Bank Account
        /// </summary>
        [EnumMember(Value = "cont")]
        BankAccount,

        /// <summary>
        /// Cash
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash,

        /// <summary>
        /// Check
        /// </summary>
        [EnumMember(Value = "instrumente_plata")]
        Check
    }
}
