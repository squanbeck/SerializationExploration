using System.Text.Json.Serialization;
using ProtoBuf;
using Newtonsoft.Json;

namespace DataSerialization.AddressBook
{
    [JsonObject]
    [ProtoContract]
    public class Contact
    {
        [JsonProperty]
        [JsonPropertyName("name")]
        [ProtoMember(1)]
        public string Name { get; set; }

        [JsonProperty]
        [JsonPropertyName("address")]
        [ProtoMember(2)] 
        public Address Address { get; set; }

        [JsonProperty]
        [JsonPropertyName("id")]
        [ProtoMember(3)] 
        public int Id { get; set; }

        [JsonProperty]
        [JsonPropertyName("phoneNumber")]
        [ProtoMember(4)]
        public int PhoneNumber { get; set; }

        [JsonProperty]
        [JsonPropertyName("relation")]
        [ProtoMember(5)]
        public Relation Relation { get; set; }

        [JsonProperty]
        [JsonPropertyName("birthday")]
        [ProtoMember(6)]
        public string Birthday { get; set; }
    }

    [ProtoContract]
    public enum Relation
    {
        [ProtoEnum]
        Business = 0,
        [ProtoEnum]
        Friend = 1,
        [ProtoEnum]
        Family = 2,
        [ProtoEnum]
        Aquaintance = 3
    }
}
