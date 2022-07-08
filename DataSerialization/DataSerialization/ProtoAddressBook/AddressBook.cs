// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddressBook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DataSerialization.ProtoAddressBook {

  /// <summary>Holder for reflection information generated from AddressBook.proto</summary>
  public static partial class AddressBookReflection {

    #region Descriptor
    /// <summary>File descriptor for AddressBook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressBookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFBZGRyZXNzQm9vay5wcm90bxIiRGF0YVNlcmlhbGl6YXRpb24uUHJvdG9B",
            "ZGRyZXNzQm9vayJxCgdBZGRyZXNzEhQKDFN0cmVldE51bWJlchgBIAEoBRIO",
            "CgZTdHJlZXQYAiABKAkSDAoEQ2l0eRgDIAEoCRINCgVTdGF0ZRgEIAEoCRIP",
            "CgdDb3VudHJ5GAUgASgJEhIKClBvc3RhbENvZGUYBiABKAUiTAoLQWRkcmVz",
            "c0Jvb2sSPQoIQ29udGFjdHMYASADKAsyKy5EYXRhU2VyaWFsaXphdGlvbi5Q",
            "cm90b0FkZHJlc3NCb29rLkNvbnRhY3QiyAEKB0NvbnRhY3QSDAoETmFtZRgB",
            "IAEoCRI8CgdBZGRyZXNzGAIgASgLMisuRGF0YVNlcmlhbGl6YXRpb24uUHJv",
            "dG9BZGRyZXNzQm9vay5BZGRyZXNzEgoKAklkGAMgASgFEhMKC1Bob25lTnVt",
            "YmVyGAQgASgFEj4KCFJlbGF0aW9uGAUgASgOMiwuRGF0YVNlcmlhbGl6YXRp",
            "b24uUHJvdG9BZGRyZXNzQm9vay5SZWxhdGlvbhIQCghCaXJ0aGRheRgGIAEo",
            "CSpBCghSZWxhdGlvbhIMCghCdXNpbmVzcxAAEgoKBkZyaWVuZBABEgoKBkZh",
            "bWlseRACEg8KC0FxdWFpbnRhbmNlEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::DataSerialization.ProtoAddressBook.Relation), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DataSerialization.ProtoAddressBook.Address), global::DataSerialization.ProtoAddressBook.Address.Parser, new[]{ "StreetNumber", "Street", "City", "State", "Country", "PostalCode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataSerialization.ProtoAddressBook.AddressBook), global::DataSerialization.ProtoAddressBook.AddressBook.Parser, new[]{ "Contacts" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::DataSerialization.ProtoAddressBook.Contact), global::DataSerialization.ProtoAddressBook.Contact.Parser, new[]{ "Name", "Address", "Id", "PhoneNumber", "Relation", "Birthday" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Relation {
    [pbr::OriginalName("Business")] Business = 0,
    [pbr::OriginalName("Friend")] Friend = 1,
    [pbr::OriginalName("Family")] Family = 2,
    [pbr::OriginalName("Aquaintance")] Aquaintance = 3,
  }

  #endregion

  #region Messages
  public sealed partial class Address : pb::IMessage<Address>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Address> _parser = new pb::MessageParser<Address>(() => new Address());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Address> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataSerialization.ProtoAddressBook.AddressBookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Address() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Address(Address other) : this() {
      streetNumber_ = other.streetNumber_;
      street_ = other.street_;
      city_ = other.city_;
      state_ = other.state_;
      country_ = other.country_;
      postalCode_ = other.postalCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Address Clone() {
      return new Address(this);
    }

    /// <summary>Field number for the "StreetNumber" field.</summary>
    public const int StreetNumberFieldNumber = 1;
    private int streetNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StreetNumber {
      get { return streetNumber_; }
      set {
        streetNumber_ = value;
      }
    }

    /// <summary>Field number for the "Street" field.</summary>
    public const int StreetFieldNumber = 2;
    private string street_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Street {
      get { return street_; }
      set {
        street_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "City" field.</summary>
    public const int CityFieldNumber = 3;
    private string city_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string City {
      get { return city_; }
      set {
        city_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "State" field.</summary>
    public const int StateFieldNumber = 4;
    private string state_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string State {
      get { return state_; }
      set {
        state_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Country" field.</summary>
    public const int CountryFieldNumber = 5;
    private string country_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Country {
      get { return country_; }
      set {
        country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "PostalCode" field.</summary>
    public const int PostalCodeFieldNumber = 6;
    private int postalCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Address);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Address other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StreetNumber != other.StreetNumber) return false;
      if (Street != other.Street) return false;
      if (City != other.City) return false;
      if (State != other.State) return false;
      if (Country != other.Country) return false;
      if (PostalCode != other.PostalCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StreetNumber != 0) hash ^= StreetNumber.GetHashCode();
      if (Street.Length != 0) hash ^= Street.GetHashCode();
      if (City.Length != 0) hash ^= City.GetHashCode();
      if (State.Length != 0) hash ^= State.GetHashCode();
      if (Country.Length != 0) hash ^= Country.GetHashCode();
      if (PostalCode != 0) hash ^= PostalCode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (StreetNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StreetNumber);
      }
      if (Street.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Street);
      }
      if (City.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(City);
      }
      if (State.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(State);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Country);
      }
      if (PostalCode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(PostalCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (StreetNumber != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StreetNumber);
      }
      if (Street.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Street);
      }
      if (City.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(City);
      }
      if (State.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(State);
      }
      if (Country.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Country);
      }
      if (PostalCode != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(PostalCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (StreetNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StreetNumber);
      }
      if (Street.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Street);
      }
      if (City.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(City);
      }
      if (State.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(State);
      }
      if (Country.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
      }
      if (PostalCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PostalCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Address other) {
      if (other == null) {
        return;
      }
      if (other.StreetNumber != 0) {
        StreetNumber = other.StreetNumber;
      }
      if (other.Street.Length != 0) {
        Street = other.Street;
      }
      if (other.City.Length != 0) {
        City = other.City;
      }
      if (other.State.Length != 0) {
        State = other.State;
      }
      if (other.Country.Length != 0) {
        Country = other.Country;
      }
      if (other.PostalCode != 0) {
        PostalCode = other.PostalCode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            StreetNumber = input.ReadInt32();
            break;
          }
          case 18: {
            Street = input.ReadString();
            break;
          }
          case 26: {
            City = input.ReadString();
            break;
          }
          case 34: {
            State = input.ReadString();
            break;
          }
          case 42: {
            Country = input.ReadString();
            break;
          }
          case 48: {
            PostalCode = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            StreetNumber = input.ReadInt32();
            break;
          }
          case 18: {
            Street = input.ReadString();
            break;
          }
          case 26: {
            City = input.ReadString();
            break;
          }
          case 34: {
            State = input.ReadString();
            break;
          }
          case 42: {
            Country = input.ReadString();
            break;
          }
          case 48: {
            PostalCode = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AddressBook : pb::IMessage<AddressBook>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataSerialization.ProtoAddressBook.AddressBookReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressBook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressBook(AddressBook other) : this() {
      contacts_ = other.contacts_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressBook Clone() {
      return new AddressBook(this);
    }

    /// <summary>Field number for the "Contacts" field.</summary>
    public const int ContactsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::DataSerialization.ProtoAddressBook.Contact> _repeated_contacts_codec
        = pb::FieldCodec.ForMessage(10, global::DataSerialization.ProtoAddressBook.Contact.Parser);
    private readonly pbc::RepeatedField<global::DataSerialization.ProtoAddressBook.Contact> contacts_ = new pbc::RepeatedField<global::DataSerialization.ProtoAddressBook.Contact>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::DataSerialization.ProtoAddressBook.Contact> Contacts {
      get { return contacts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddressBook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddressBook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!contacts_.Equals(other.contacts_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= contacts_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      contacts_.WriteTo(output, _repeated_contacts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      contacts_.WriteTo(ref output, _repeated_contacts_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += contacts_.CalculateSize(_repeated_contacts_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddressBook other) {
      if (other == null) {
        return;
      }
      contacts_.Add(other.contacts_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            contacts_.AddEntriesFrom(input, _repeated_contacts_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            contacts_.AddEntriesFrom(ref input, _repeated_contacts_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class Contact : pb::IMessage<Contact>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Contact> _parser = new pb::MessageParser<Contact>(() => new Contact());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Contact> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DataSerialization.ProtoAddressBook.AddressBookReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Contact() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Contact(Contact other) : this() {
      name_ = other.name_;
      address_ = other.address_ != null ? other.address_.Clone() : null;
      id_ = other.id_;
      phoneNumber_ = other.phoneNumber_;
      relation_ = other.relation_;
      birthday_ = other.birthday_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Contact Clone() {
      return new Contact(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Address" field.</summary>
    public const int AddressFieldNumber = 2;
    private global::DataSerialization.ProtoAddressBook.Address address_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::DataSerialization.ProtoAddressBook.Address Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 3;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "PhoneNumber" field.</summary>
    public const int PhoneNumberFieldNumber = 4;
    private int phoneNumber_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = value;
      }
    }

    /// <summary>Field number for the "Relation" field.</summary>
    public const int RelationFieldNumber = 5;
    private global::DataSerialization.ProtoAddressBook.Relation relation_ = global::DataSerialization.ProtoAddressBook.Relation.Business;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::DataSerialization.ProtoAddressBook.Relation Relation {
      get { return relation_; }
      set {
        relation_ = value;
      }
    }

    /// <summary>Field number for the "Birthday" field.</summary>
    public const int BirthdayFieldNumber = 6;
    private string birthday_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Birthday {
      get { return birthday_; }
      set {
        birthday_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Contact);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Contact other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Address, other.Address)) return false;
      if (Id != other.Id) return false;
      if (PhoneNumber != other.PhoneNumber) return false;
      if (Relation != other.Relation) return false;
      if (Birthday != other.Birthday) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (address_ != null) hash ^= Address.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      if (PhoneNumber != 0) hash ^= PhoneNumber.GetHashCode();
      if (Relation != global::DataSerialization.ProtoAddressBook.Relation.Business) hash ^= Relation.GetHashCode();
      if (Birthday.Length != 0) hash ^= Birthday.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (address_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Address);
      }
      if (Id != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Id);
      }
      if (PhoneNumber != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PhoneNumber);
      }
      if (Relation != global::DataSerialization.ProtoAddressBook.Relation.Business) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Relation);
      }
      if (Birthday.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Birthday);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (address_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Address);
      }
      if (Id != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Id);
      }
      if (PhoneNumber != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(PhoneNumber);
      }
      if (Relation != global::DataSerialization.ProtoAddressBook.Relation.Business) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Relation);
      }
      if (Birthday.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Birthday);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (address_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Address);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (PhoneNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PhoneNumber);
      }
      if (Relation != global::DataSerialization.ProtoAddressBook.Relation.Business) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Relation);
      }
      if (Birthday.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Birthday);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Contact other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.address_ != null) {
        if (address_ == null) {
          Address = new global::DataSerialization.ProtoAddressBook.Address();
        }
        Address.MergeFrom(other.Address);
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.PhoneNumber != 0) {
        PhoneNumber = other.PhoneNumber;
      }
      if (other.Relation != global::DataSerialization.ProtoAddressBook.Relation.Business) {
        Relation = other.Relation;
      }
      if (other.Birthday.Length != 0) {
        Birthday = other.Birthday;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (address_ == null) {
              Address = new global::DataSerialization.ProtoAddressBook.Address();
            }
            input.ReadMessage(Address);
            break;
          }
          case 24: {
            Id = input.ReadInt32();
            break;
          }
          case 32: {
            PhoneNumber = input.ReadInt32();
            break;
          }
          case 40: {
            Relation = (global::DataSerialization.ProtoAddressBook.Relation) input.ReadEnum();
            break;
          }
          case 50: {
            Birthday = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (address_ == null) {
              Address = new global::DataSerialization.ProtoAddressBook.Address();
            }
            input.ReadMessage(Address);
            break;
          }
          case 24: {
            Id = input.ReadInt32();
            break;
          }
          case 32: {
            PhoneNumber = input.ReadInt32();
            break;
          }
          case 40: {
            Relation = (global::DataSerialization.ProtoAddressBook.Relation) input.ReadEnum();
            break;
          }
          case 50: {
            Birthday = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
