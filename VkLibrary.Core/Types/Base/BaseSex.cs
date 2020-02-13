using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Base
{
    public enum BaseSex
    {
        [EnumMember(Value = "unknown")]
        Unknown = 0,
        [EnumMember(Value = "female")]
        Female = 1,
        [EnumMember(Value = "male")]
        Male = 2
    }
}