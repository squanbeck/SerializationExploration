# Engineering Notes for Avro/Protobuf/Json Exploration/Benchmarking

Notes key: s/d = serializ(e, ing, ation) / deseriliz(e, ing, ation)

## Benchmarking

### Libraries used

- Apache.Avro
- Google.Protobuf
- Newtonsoft.Json
- Newtonsoft.Json.Bson
- Protobuf-Net
- System.Text.Json

### Results

:::image type="content" source="BenchmarkingResults/Results1.png" alt-text="results1":::
:::image type="content" source="BenchmarkingResults/Results2.png" alt-text="results2":::

Looking at these screenshots, it is fairly obvious that Protobuf is probably the way to go for efficiency. Although Avro serializes to a slightly smaller number of bytes, protobuf is over twice as fast at deserialization and just under twice as fast at serialization.

Some side notes:

- Avro is actually slower in s/d than System.Text.Json
- System.Text.Json seems to be nearly twice as fast at s/d than Newtonsoft.Json
- Protobuf-Net and Google.Protobuf seem to be pretty similar at s/d speed (Protobuf-Net may be easier to use, though.)
- Newtonsoft.Json.Bson has pretty miserable performance as it is both significantly slower than any other option seen here, as well as barely better in size than Json.

### Process

- In order to s/d, some of these libraries require c# code generation from their schema format. As learning all of these schemas and attempting to mimic them perfectly between each option (C# classes, JSON, Avro, and Protobuf) was unlikely to work well or quickly, some extra libraries were used to create the schemas from the initial c# classes created. Microsoft.Hadoop.Avro2 was used to create the Avro schema file: [schema.avsc](./Schemas/schema.avsc) and Protobuf-net was used to create the Protobuf schema file: [AddressBook.proto](./Schemas/AddressBook.proto). These schema files were reviewed and did not seem to contain any extra information that would hinder the benchmarks in any way.
- For the benchmarking logic itself, a Jon Skeet gem, [benchmark.cs](./DataSerialization/DataSerialization/Benchmark.cs), was used. This utilized forced garbage collection in order to ensure that each test was run in such a way that the other tests would not interfere.
- All of the data for the benchmark was created through AutoFixture, which included creating 100,000 Contacts within an AddressBook to be s/d.

#### Apache.Avro

1. Using the pre-written [C# classes](./DataSerialization/DataSerialization/AddressBook/), the Avro schema file was generated.
1. Using the avrogen.exe utility (found in the Apache.Avro.Tools nuget package), the Avro [C# classes](./DataSerialization/DataSerialization/AvroAddressBook/) were created.
1. Using the same data as the other benchmarks, but converted to the new Avro classes, the benchmark was performed.

The assumption here is that you do not have to copy the data from the Avro generated classes to your normal classes. If you do have to perform such a copy, the s/d performance would be worse.

#### Google.Protobuf

1. Using the pre-written [C# classes](./DataSerialization/DataSerialization/AddressBook/), the Protobuf schema file was generated.
1. Using the protoc.exe utility (obtained through chocolatey package Protocol Buffers), the [C# classes](./DataSerialization/DataSerialization/ProtoAddressBook/AddressBook.cs) were created.
1. Using the same data as the other benchmarks, but converted to the new Protobuf classes, the benchmark was performed.

The assumption here is that you do not have to copy the data from the Protobuf generated classes to your normal classes. If you do have to perform such a copy, the s/d performance would be worse.

#### Protobuf-Net

1. Unlike the Google.Protobuf package, this package uses the pre-written C# classes but with attributes added. It does not rely on a written schema file.
1. Using the generated data, the benchmark was performed.

#### JSON/BSON

1. As these are very common packages, they won't be described in as much detail. Without any need for code generation and using attributes on the C# properties and classes, the benchmark was performed using the generated data.