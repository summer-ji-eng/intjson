// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: intjson.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Intjson {

  /// <summary>Holder for reflection information generated from intjson.proto</summary>
  public static partial class IntjsonReflection {

    #region Descriptor
    /// <summary>File descriptor for intjson.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IntjsonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg1pbnRqc29uLnByb3RvEgdpbnRqc29uImQKB051bWJlcnMSDQoFbGFiZWwY",
            "ASABKAkSEAoIc2lnbmVkNjQYAiABKAMSEgoKdW5zaWduZWQ2NBgDIAEoBBIQ",
            "CghzaWduZWQzMhgEIAEoBRISCgp1bnNpZ25lZDMyGAUgASgNQg9aDXByb3Rv",
            "L2ludGpzb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Intjson.Numbers), global::Intjson.Numbers.Parser, new[]{ "Label", "Signed64", "Unsigned64", "Signed32", "Unsigned32" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Numbers : pb::IMessage<Numbers>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Numbers> _parser = new pb::MessageParser<Numbers>(() => new Numbers());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Numbers> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Intjson.IntjsonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Numbers() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Numbers(Numbers other) : this() {
      label_ = other.label_;
      signed64_ = other.signed64_;
      unsigned64_ = other.unsigned64_;
      signed32_ = other.signed32_;
      unsigned32_ = other.unsigned32_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Numbers Clone() {
      return new Numbers(this);
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 1;
    private string label_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "signed64" field.</summary>
    public const int Signed64FieldNumber = 2;
    private long signed64_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Signed64 {
      get { return signed64_; }
      set {
        signed64_ = value;
      }
    }

    /// <summary>Field number for the "unsigned64" field.</summary>
    public const int Unsigned64FieldNumber = 3;
    private ulong unsigned64_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Unsigned64 {
      get { return unsigned64_; }
      set {
        unsigned64_ = value;
      }
    }

    /// <summary>Field number for the "signed32" field.</summary>
    public const int Signed32FieldNumber = 4;
    private int signed32_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Signed32 {
      get { return signed32_; }
      set {
        signed32_ = value;
      }
    }

    /// <summary>Field number for the "unsigned32" field.</summary>
    public const int Unsigned32FieldNumber = 5;
    private uint unsigned32_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Unsigned32 {
      get { return unsigned32_; }
      set {
        unsigned32_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Numbers);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Numbers other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Label != other.Label) return false;
      if (Signed64 != other.Signed64) return false;
      if (Unsigned64 != other.Unsigned64) return false;
      if (Signed32 != other.Signed32) return false;
      if (Unsigned32 != other.Unsigned32) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (Signed64 != 0L) hash ^= Signed64.GetHashCode();
      if (Unsigned64 != 0UL) hash ^= Unsigned64.GetHashCode();
      if (Signed32 != 0) hash ^= Signed32.GetHashCode();
      if (Unsigned32 != 0) hash ^= Unsigned32.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Label.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Label);
      }
      if (Signed64 != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Signed64);
      }
      if (Unsigned64 != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unsigned64);
      }
      if (Signed32 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Signed32);
      }
      if (Unsigned32 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unsigned32);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Label.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Label);
      }
      if (Signed64 != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Signed64);
      }
      if (Unsigned64 != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Unsigned64);
      }
      if (Signed32 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Signed32);
      }
      if (Unsigned32 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Unsigned32);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (Signed64 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Signed64);
      }
      if (Unsigned64 != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Unsigned64);
      }
      if (Signed32 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Signed32);
      }
      if (Unsigned32 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Unsigned32);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Numbers other) {
      if (other == null) {
        return;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      if (other.Signed64 != 0L) {
        Signed64 = other.Signed64;
      }
      if (other.Unsigned64 != 0UL) {
        Unsigned64 = other.Unsigned64;
      }
      if (other.Signed32 != 0) {
        Signed32 = other.Signed32;
      }
      if (other.Unsigned32 != 0) {
        Unsigned32 = other.Unsigned32;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Label = input.ReadString();
            break;
          }
          case 16: {
            Signed64 = input.ReadInt64();
            break;
          }
          case 24: {
            Unsigned64 = input.ReadUInt64();
            break;
          }
          case 32: {
            Signed32 = input.ReadInt32();
            break;
          }
          case 40: {
            Unsigned32 = input.ReadUInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Label = input.ReadString();
            break;
          }
          case 16: {
            Signed64 = input.ReadInt64();
            break;
          }
          case 24: {
            Unsigned64 = input.ReadUInt64();
            break;
          }
          case 32: {
            Signed32 = input.ReadInt32();
            break;
          }
          case 40: {
            Unsigned32 = input.ReadUInt32();
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