// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: fds/protobuf/stach/table/TableDefinition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace FactSet.Protobuf.Stach.Table {

  /// <summary>Holder for reflection information generated from fds/protobuf/stach/table/TableDefinition.proto</summary>
  public static partial class TableDefinitionReflection {

    #region Descriptor
    /// <summary>File descriptor for fds/protobuf/stach/table/TableDefinition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TableDefinitionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5mZHMvcHJvdG9idWYvc3RhY2gvdGFibGUvVGFibGVEZWZpbml0aW9uLnBy",
            "b3RvEhxmYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlGi9mZHMvcHJvdG9i",
            "dWYvc3RhY2gvdGFibGUvQ29sdW1uRGVmaW5pdGlvbi5wcm90byJrCg9UYWJs",
            "ZURlZmluaXRpb24SFwoPaGVhZGVyX3RhYmxlX2lkGAEgASgJEj8KB2NvbHVt",
            "bnMYAiADKAsyLi5mYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRhYmxlLkNvbHVt",
            "bkRlZmluaXRpb25ClgEKIGNvbS5mYWN0c2V0LnByb3RvYnVmLnN0YWNoLnRh",
            "YmxlQhRUYWJsZURlZmluaXRpb25Qcm90b1o9Z2l0aHViLmNvbS9mYWN0c2V0",
            "L3N0YWNoc2NoZW1hL2dvL3YyL2Zkcy9wcm90b2J1Zi9zdGFjaC90YWJsZaoC",
            "HEZhY3RTZXQuUHJvdG9idWYuU3RhY2guVGFibGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::FactSet.Protobuf.Stach.Table.ColumnDefinitionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::FactSet.Protobuf.Stach.Table.TableDefinition), global::FactSet.Protobuf.Stach.Table.TableDefinition.Parser, new[]{ "HeaderTableId", "Columns" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A table definition
  /// </summary>
  public sealed partial class TableDefinition : pb::IMessage<TableDefinition> {
    private static readonly pb::MessageParser<TableDefinition> _parser = new pb::MessageParser<TableDefinition>(() => new TableDefinition());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TableDefinition> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::FactSet.Protobuf.Stach.Table.TableDefinitionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TableDefinition() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TableDefinition(TableDefinition other) : this() {
      headerTableId_ = other.headerTableId_;
      columns_ = other.columns_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TableDefinition Clone() {
      return new TableDefinition(this);
    }

    /// <summary>Field number for the "header_table_id" field.</summary>
    public const int HeaderTableIdFieldNumber = 1;
    private string headerTableId_ = "";
    /// <summary>
    /// The id of the headers table
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HeaderTableId {
      get { return headerTableId_; }
      set {
        headerTableId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "columns" field.</summary>
    public const int ColumnsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::FactSet.Protobuf.Stach.Table.ColumnDefinition> _repeated_columns_codec
        = pb::FieldCodec.ForMessage(18, global::FactSet.Protobuf.Stach.Table.ColumnDefinition.Parser);
    private readonly pbc::RepeatedField<global::FactSet.Protobuf.Stach.Table.ColumnDefinition> columns_ = new pbc::RepeatedField<global::FactSet.Protobuf.Stach.Table.ColumnDefinition>();
    /// <summary>
    /// The array of column definitions
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::FactSet.Protobuf.Stach.Table.ColumnDefinition> Columns {
      get { return columns_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TableDefinition);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TableDefinition other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HeaderTableId != other.HeaderTableId) return false;
      if(!columns_.Equals(other.columns_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HeaderTableId.Length != 0) hash ^= HeaderTableId.GetHashCode();
      hash ^= columns_.GetHashCode();
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
      if (HeaderTableId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(HeaderTableId);
      }
      columns_.WriteTo(output, _repeated_columns_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HeaderTableId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HeaderTableId);
      }
      size += columns_.CalculateSize(_repeated_columns_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TableDefinition other) {
      if (other == null) {
        return;
      }
      if (other.HeaderTableId.Length != 0) {
        HeaderTableId = other.HeaderTableId;
      }
      columns_.Add(other.columns_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            HeaderTableId = input.ReadString();
            break;
          }
          case 18: {
            columns_.AddEntriesFrom(input, _repeated_columns_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code