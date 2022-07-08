using ProtoBuf;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace DataSerialization.AddressBook
{
    [JsonObject]
    [ProtoContract]
    public class Address
    {
        [JsonProperty]
        [JsonPropertyName("streetNumber")]
        [ProtoMember(1)]
        public int StreetNumber { get; set; }

        [JsonProperty]
        [JsonPropertyName("street")]
        [ProtoMember(2)]
        public string Street { get; set; }

        [JsonProperty]
        [JsonPropertyName("city")]
        [ProtoMember(3)] 
        public string City { get; set; }

        [JsonProperty]
        [JsonPropertyName("state")]
        [ProtoMember(4)] 
        public string State { get; set; }

        [JsonProperty]
        [JsonPropertyName("country")]
        [ProtoMember(5)] 
        public string Country { get; set; }

        [JsonProperty]
        [JsonPropertyName("postalCode")]
        [ProtoMember(6)] 
        public int PostalCode { get; set; }
    }
}
