using System.Text.Json.Serialization;
using ProtoBuf;
using Newtonsoft.Json;

namespace DataSerialization.AddressBook
{
    [JsonObject]
    [ProtoContract]
    public class AddressBook
    {
        [JsonProperty]
        [JsonPropertyName("contacts")]
        [ProtoMember(1)]
        public Contact[] Contacts { get; set; }
    }
}
