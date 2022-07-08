namespace DataSerialization
{
    using ProtoBuf;
    using AutoFixture;
    using Avro.IO;
    using Avro.Specific;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Bson;
    using Google.Protobuf;

    public class SerializationBenchmarks
    {
        static Fixture fixture;
        static AddressBook.AddressBook addressBook;
        static AvroAddressBook.AddressBook avroAddressBook;
        static ProtoAddressBook.AddressBook protoAddressBook;
        static int size = 100000;
        static string result;
        static byte[] resultBytes;
        static byte[] serializedProtobufNet;
        static byte[] serializedGoogleProtobuf;
        static byte[] serializedAvro;
        static byte[] serializedBson;
        static string systemSerializedJson;
        static string newtonSerializedJson;
        static AddressBook.AddressBook resultAddressBook;
        static AvroAddressBook.AddressBook resultAvroAddressBook;
        static ProtoAddressBook.AddressBook resultProtoAddressBook;

        public static void Init(string[] args)
        {
            if (args.Length > 0)
            {
                size = Int32.Parse(args[0]);
            }

            // Set up objects for serialization
            fixture = new Fixture();
            fixture.RepeatCount = size;
            addressBook = fixture.Create<AddressBook.AddressBook>();
            avroAddressBook = new AvroAddressBook.AddressBook();
            avroAddressBook.Contacts = addressBook.Contacts.Select(x => new AvroAddressBook.Contact()
            {
                Id = x.Id,
                Name = x.Name,
                Address = new AvroAddressBook.Address()
                {
                    StreetNumber = x.Address.StreetNumber,
                    City = x.Address.City,
                    PostalCode = x.Address.PostalCode,
                    Country = x.Address.Country,
                    Street = x.Address.Street,
                    State = x.Address.State
                },
                PhoneNumber = x.PhoneNumber,
                Relation = (AvroAddressBook.Relation)x.Relation,
                Birthday = x.Birthday
            }).ToList();

            protoAddressBook = new();
            foreach(var x in addressBook.Contacts)
            {
                protoAddressBook.Contacts.Add(new ProtoAddressBook.Contact()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Address = new ProtoAddressBook.Address()
                    {
                        StreetNumber = x.Address.StreetNumber,
                        City = x.Address.City,
                        PostalCode = x.Address.PostalCode,
                        Country = x.Address.Country,
                        Street = x.Address.Street,
                        State = x.Address.State
                    },
                    PhoneNumber = x.PhoneNumber,
                    Relation = (ProtoAddressBook.Relation)x.Relation,
                    Birthday = x.Birthday
                });
            }

            // Set up pre-serialized objects for deserialization tests
            using (var ms = new MemoryStream())
            {
                var enc = new BinaryEncoder(ms);
                var writer = new SpecificDefaultWriter(AvroAddressBook.AddressBook._SCHEMA);
                writer.Write(avroAddressBook, enc);
                serializedAvro = ms.ToArray();
            }

            using (var ms = new MemoryStream())
            {
                Serializer.NonGeneric.Serialize(ms, addressBook);
                serializedProtobufNet = ms.ToArray();
            }

            using (var ms = new MemoryStream())
            using (var writer = new BsonDataWriter(ms))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Serialize(writer, addressBook);
                serializedBson = ms.ToArray();
            }

            using (var ms = new MemoryStream())
            {
                protoAddressBook.WriteTo(ms);
                serializedGoogleProtobuf = ms.ToArray();
            }
            systemSerializedJson = System.Text.Json.JsonSerializer.Serialize(addressBook);
            newtonSerializedJson = JsonConvert.SerializeObject(addressBook);
        }

        public static object Check()
        {
            if (result == null)
            {
                if (resultBytes == null)
                    return null;

                return resultBytes.Length;
            }

            return System.Text.Encoding.UTF8.GetByteCount(result);
        }

        public static void Reset()
        {
            result = null;
            resultBytes = null;
            resultAddressBook = null;
            resultAvroAddressBook = null;
            resultProtoAddressBook = null;
        }

        [Benchmark]
        public static void Newton_Json_Serialization()
        {
            var localAddressBook = addressBook;
            var jsonSerialized = JsonConvert.SerializeObject(localAddressBook);
            result = jsonSerialized;
        }

        [Benchmark]
        public static void Newton_Json_Deserialization()
        {
            var localSerializedJson = newtonSerializedJson;
            var localAddressBook = JsonConvert.DeserializeObject<AddressBook.AddressBook>(localSerializedJson);
            resultAddressBook = localAddressBook;
        }

        [Benchmark]
        public static void Bson_Serialization()
        {
            using (var ms = new MemoryStream())
            using (var writer = new BsonDataWriter(ms))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                serializer.Serialize(writer, addressBook);
                resultBytes = ms.ToArray();
            }
        }

        [Benchmark]
        public static void Bson_Deserialization()
        {
            using (var ms = new MemoryStream(serializedBson))
            using (var reader = new BsonDataReader(ms))
            {
                var serializer = new Newtonsoft.Json.JsonSerializer();
                resultAddressBook = serializer.Deserialize<AddressBook.AddressBook>(reader);
            }
        }

        [Benchmark]
        public static void System_Json_Serialization()
        {
            var localAddressBook = addressBook;
            var jsonSerialized = System.Text.Json.JsonSerializer.Serialize(localAddressBook);
            result = jsonSerialized;
        }

        [Benchmark]
        public static void System_Json_Deserialization()
        {
            var localSerializedJson = systemSerializedJson;
            var localAddressBook = System.Text.Json.JsonSerializer.Deserialize<AddressBook.AddressBook>(localSerializedJson);
            resultAddressBook = localAddressBook;
        }

        [Benchmark]
        public static void Avro_Serialization()
        {
            var localAddressBook = avroAddressBook;
            using (var ms = new MemoryStream())
            {
                var enc = new BinaryEncoder(ms);
                var writer = new SpecificDefaultWriter(AvroAddressBook.AddressBook._SCHEMA);
                writer.Write(localAddressBook, enc);
                resultBytes = ms.ToArray();
            }
        }

        [Benchmark]
        public static void Avro_Deserialization()
        {
            var localSerializedAvro = serializedAvro;
            using (var ms = new MemoryStream(localSerializedAvro))
            {
                var dec = new BinaryDecoder(ms);
                var reader = new SpecificDefaultReader(AvroAddressBook.AddressBook._SCHEMA, AvroAddressBook.AddressBook._SCHEMA);
                var localAvroAddressBook = new AvroAddressBook.AddressBook();
                reader.Read(localAvroAddressBook, dec);
                resultAvroAddressBook = localAvroAddressBook;
            }
        }

        [Benchmark]
        public static void Protobuf_Net_Serialization()
        {
            using (var ms = new MemoryStream())
            {
                Serializer.NonGeneric.Serialize(ms, addressBook);
                resultBytes = ms.ToArray();
            }
        }

        [Benchmark]
        public static void Protobuf_Net_Deserialization()
        {
            var localSerializedProtobuf = serializedProtobufNet;
            using (var ms = new MemoryStream(localSerializedProtobuf))
            {
                resultAddressBook = Serializer.Deserialize<AddressBook.AddressBook>(ms);
            }
        }

        [Benchmark]
        public static void Google_Protobuf_Serialization()
        {
            using (var ms = new MemoryStream())
            {
                protoAddressBook.WriteTo(ms);
                resultBytes = ms.ToArray();
            }
        }

        [Benchmark]
        public static void Google_Protobuf_Deserialization()
        {
            using (var ms = new MemoryStream(serializedGoogleProtobuf))
            {
                resultProtoAddressBook = ProtoAddressBook.AddressBook.Parser.ParseFrom(ms);
            }
        }
    }
}