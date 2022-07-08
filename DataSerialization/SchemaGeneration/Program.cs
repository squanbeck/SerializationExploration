using Newtonsoft.Json.Schema.Generation;
using DataSerialization.AddressBook;
using ProtoBuf;

namespace SchemaGeneration
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var generator = new JSchemaGenerator();
            var jSchema = generator.Generate(typeof(AddressBook));
            await File.WriteAllTextAsync("schema.json", jSchema.ToString());

            var settings = new Microsoft.Hadoop.Avro.AvroSerializerSettings();
            settings.Resolver = new Microsoft.Hadoop.Avro.AvroPublicMemberContractResolver();
            var aSchema = Microsoft.Hadoop.Avro.AvroSerializer.Create<AddressBook>(settings).WriterSchema;
            await File.WriteAllTextAsync("schema.avsc", aSchema.ToString());

            var pSchema = Serializer.GetProto<AddressBook>();
            await File.WriteAllTextAsync("schema.proto", pSchema.ToString());
        }
    }
}