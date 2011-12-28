// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!

#pragma warning disable 1591, 0612

#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;

namespace BehaviorTree
{
	namespace Proto
	{
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute(),
		 global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
		 global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    
    
		public static partial class Person
		{
			#region Extension registration

			public static void RegisterAllExtensions(pb::ExtensionRegistry registry)
			{
			}

			#endregion

			#region Static variables

			internal static pbd::MessageDescriptor internal__static_BehaviorTree_Person__Descriptor;

			internal static pb::FieldAccess.FieldAccessorTable<global::BehaviorTree.Person, global::BehaviorTree.Person.Builder>
					internal__static_BehaviorTree_Person__FieldAccessorTable;

			internal static pbd::MessageDescriptor internal__static_BehaviorTree_Group__Descriptor;

			internal static pb::FieldAccess.FieldAccessorTable<global::BehaviorTree.Group, global::BehaviorTree.Group.Builder>
					internal__static_BehaviorTree_Group__FieldAccessorTable;

			#endregion

			#region Descriptor

			public static pbd::FileDescriptor Descriptor
			{
				get
				{
					return descriptor;
				}
			}

			private static pbd::FileDescriptor descriptor;

			static Person()
			{
				byte[] descriptorData =
						global::System.Convert.FromBase64String(
						                                        "CgxQZXJzb24ucHJvdG8SDEJlaGF2aW9yVHJlZRokZ29vZ2xlL3Byb3RvYnVm" +
						                                        		"L2NzaGFycF9vcHRpb25zLnByb3RvIiIKBlBlcnNvbhILCgNudW0YASACKAUS" +
						                                        				"CwoDYWdlGAIgASgFIi4KBUdyb3VwEiUKB3BlcnNvbnMYASADKAsyFC5CZWhh" +
						                                        						"dmlvclRyZWUuUGVyc29u");
				pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root)
				                                                          	{
				                                                          		descriptor = root;
				                                                          		internal__static_BehaviorTree_Person__Descriptor =
				                                                          				Descriptor.MessageTypes[0];
				                                                          		internal__static_BehaviorTree_Person__FieldAccessorTable
				                                                          				=
				                                                          				new pb::FieldAccess.FieldAccessorTable
				                                                          						<global::BehaviorTree.Person,
				                                                          								global::BehaviorTree.Person.Builder>(
				                                                          						internal__static_BehaviorTree_Person__Descriptor,
				                                                          						new string[] {"Num", "Age",});
				                                                          		internal__static_BehaviorTree_Group__Descriptor =
				                                                          				Descriptor.MessageTypes[1];
				                                                          		internal__static_BehaviorTree_Group__FieldAccessorTable
				                                                          				=
				                                                          				new pb::FieldAccess.FieldAccessorTable
				                                                          						<global::BehaviorTree.Group,
				                                                          								global::BehaviorTree.Group.Builder>(
				                                                          						internal__static_BehaviorTree_Group__Descriptor,
				                                                          						new string[] {"Persons",});
				                                                          		return null;
				                                                          	};
				pbd::FileDescriptor.InternalBuildGeneratedFileFrom(
				                                                   descriptorData,
				                                                   new pbd::FileDescriptor[]
				                                                   	{
				                                                   			global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.
				                                                   					Descriptor,
				                                                   	}, assigner);
			}

			#endregion
		}
	}

	#region Messages

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute(),
	 global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
	 global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  
  
	public sealed partial class Person : pb::GeneratedMessage<Person, Person.Builder>
	{
		private Person()
		{
		}

		private static readonly Person defaultInstance = new Person().MakeReadOnly();
		private static readonly string[] _personFieldNames = new string[] {"age", "num"};
		private static readonly uint[] _personFieldTags = new uint[] {16, 8};

		public static Person DefaultInstance
		{
			get
			{
				return defaultInstance;
			}
		}

		public override Person DefaultInstanceForType
		{
			get
			{
				return DefaultInstance;
			}
		}

		protected override Person ThisMessage
		{
			get
			{
				return this;
			}
		}

		public static pbd::MessageDescriptor Descriptor
		{
			get
			{
				return global::BehaviorTree.Proto.Person.internal__static_BehaviorTree_Person__Descriptor;
			}
		}

		protected override pb::FieldAccess.FieldAccessorTable<Person, Person.Builder> InternalFieldAccessors
		{
			get
			{
				return global::BehaviorTree.Proto.Person.internal__static_BehaviorTree_Person__FieldAccessorTable;
			}
		}

		public const int NumFieldNumber = 1;
		private bool hasNum;
		private int num_;

		public bool HasNum
		{
			get
			{
				return hasNum;
			}
		}

		public int Num
		{
			get
			{
				return num_;
			}
		}

		public const int AgeFieldNumber = 2;
		private bool hasAge;
		private int age_;

		public bool HasAge
		{
			get
			{
				return hasAge;
			}
		}

		public int Age
		{
			get
			{
				return age_;
			}
		}

		public override bool IsInitialized
		{
			get
			{
				if (!hasNum)
				{
					return false;
				}
				return true;
			}
		}

		public override void WriteTo(pb::ICodedOutputStream output)
		{
			int size = SerializedSize;
			string[] field_names = _personFieldNames;
			if (hasNum)
			{
				output.WriteInt32(1, field_names[1], Num);
			}
			if (hasAge)
			{
				output.WriteInt32(2, field_names[0], Age);
			}
			UnknownFields.WriteTo(output);
		}

		private int memoizedSerializedSize = -1;

		public override int SerializedSize
		{
			get
			{
				int size = memoizedSerializedSize;
				if (size != -1)
				{
					return size;
				}

				size = 0;
				if (hasNum)
				{
					size += pb::CodedOutputStream.ComputeInt32Size(1, Num);
				}
				if (hasAge)
				{
					size += pb::CodedOutputStream.ComputeInt32Size(2, Age);
				}
				size += UnknownFields.SerializedSize;
				memoizedSerializedSize = size;
				return size;
			}
		}

		public static Person ParseFrom(pb::ByteString data)
		{
			return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
		}

		public static Person ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
		}

		public static Person ParseFrom(byte[] data)
		{
			return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
		}

		public static Person ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
		}

		public static Person ParseFrom(global::System.IO.Stream input)
		{
			return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
		}

		public static Person ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
		}

		public static Person ParseDelimitedFrom(global::System.IO.Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		public static Person ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		public static Person ParseFrom(pb::ICodedInputStream input)
		{
			return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
		}

		public static Person ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
		}

		private Person MakeReadOnly()
		{
			return this;
		}

		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		public static Builder CreateBuilder(Person prototype)
		{
			return new Builder(prototype);
		}

		[global::System.Diagnostics.DebuggerNonUserCodeAttribute(),
		 global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
		 global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    
    
		public sealed partial class Builder : pb::GeneratedBuilder<Person, Builder>
		{
			protected override Builder ThisBuilder
			{
				get
				{
					return this;
				}
			}

			public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			internal Builder(Person cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			private bool resultIsReadOnly;
			private Person result;

			private Person PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					Person original = result;
					result = new Person();
					resultIsReadOnly = false;
					MergeFrom(original);
				}
				return result;
			}

			public override bool IsInitialized
			{
				get
				{
					return result.IsInitialized;
				}
			}

			protected override Person MessageBeingBuilt
			{
				get
				{
					return PrepareBuilder();
				}
			}

			public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				else
				{
					return new Builder().MergeFrom(result);
				}
			}

			public override pbd::MessageDescriptor DescriptorForType
			{
				get
				{
					return global::BehaviorTree.Person.Descriptor;
				}
			}

			public override Person DefaultInstanceForType
			{
				get
				{
					return global::BehaviorTree.Person.DefaultInstance;
				}
			}

			public override Person BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			public override Builder MergeFrom(pb::IMessage other)
			{
				if (other is Person)
				{
					return MergeFrom((Person) other);
				}
				else
				{
					base.MergeFrom(other);
					return this;
				}
			}

			public override Builder MergeFrom(Person other)
			{
				if (other == global::BehaviorTree.Person.DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasNum)
				{
					Num = other.Num;
				}
				if (other.HasAge)
				{
					Age = other.Age;
				}
				this.MergeUnknownFields(other.UnknownFields);
				return this;
			}

			public override Builder MergeFrom(pb::ICodedInputStream input)
			{
				return MergeFrom(input, pb::ExtensionRegistry.Empty);
			}

			public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				pb::UnknownFieldSet.Builder unknownFields = null;
				uint tag;
				string field_name;
				while (input.ReadTag(out tag, out field_name))
				{
					if (tag == 0 && field_name != null)
					{
						int field_ordinal = global::System.Array.BinarySearch(
						                                                      _personFieldNames, field_name,
						                                                      global::System.StringComparer.Ordinal);
						if (field_ordinal >= 0)
						{
							tag = _personFieldTags[field_ordinal];
						}
						else
						{
							if (unknownFields == null)
							{
								unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
							}
							ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
							continue;
						}
					}
					switch (tag)
					{
						case 0:
						{
							throw pb::InvalidProtocolBufferException.InvalidTag();
						}
						default:
						{
							if (pb::WireFormat.IsEndGroupTag(tag))
							{
								if (unknownFields != null)
								{
									this.UnknownFields = unknownFields.Build();
								}
								return this;
							}
							if (unknownFields == null)
							{
								unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
							}
							ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
							break;
						}
						case 8:
						{
							result.hasNum = input.ReadInt32(ref result.num_);
							break;
						}
						case 16:
						{
							result.hasAge = input.ReadInt32(ref result.age_);
							break;
						}
					}
				}

				if (unknownFields != null)
				{
					this.UnknownFields = unknownFields.Build();
				}
				return this;
			}

			public bool HasNum
			{
				get
				{
					return result.hasNum;
				}
			}

			public int Num
			{
				get
				{
					return result.Num;
				}
				set
				{
					SetNum(value);
				}
			}

			public Builder SetNum(int value)
			{
				PrepareBuilder();
				result.hasNum = true;
				result.num_ = value;
				return this;
			}

			public Builder ClearNum()
			{
				PrepareBuilder();
				result.hasNum = false;
				result.num_ = 0;
				return this;
			}

			public bool HasAge
			{
				get
				{
					return result.hasAge;
				}
			}

			public int Age
			{
				get
				{
					return result.Age;
				}
				set
				{
					SetAge(value);
				}
			}

			public Builder SetAge(int value)
			{
				PrepareBuilder();
				result.hasAge = true;
				result.age_ = value;
				return this;
			}

			public Builder ClearAge()
			{
				PrepareBuilder();
				result.hasAge = false;
				result.age_ = 0;
				return this;
			}
		}

		static Person()
		{
			object.ReferenceEquals(global::BehaviorTree.Proto.Person.Descriptor, null);
		}
	}

	[global::System.Diagnostics.DebuggerNonUserCodeAttribute(),
	 global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
	 global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  
  
	public sealed partial class Group : pb::GeneratedMessage<Group, Group.Builder>
	{
		private Group()
		{
		}

		private static readonly Group defaultInstance = new Group().MakeReadOnly();
		private static readonly string[] _groupFieldNames = new string[] {"persons"};
		private static readonly uint[] _groupFieldTags = new uint[] {10};

		public static Group DefaultInstance
		{
			get
			{
				return defaultInstance;
			}
		}

		public override Group DefaultInstanceForType
		{
			get
			{
				return DefaultInstance;
			}
		}

		protected override Group ThisMessage
		{
			get
			{
				return this;
			}
		}

		public static pbd::MessageDescriptor Descriptor
		{
			get
			{
				return global::BehaviorTree.Proto.Person.internal__static_BehaviorTree_Group__Descriptor;
			}
		}

		protected override pb::FieldAccess.FieldAccessorTable<Group, Group.Builder> InternalFieldAccessors
		{
			get
			{
				return global::BehaviorTree.Proto.Person.internal__static_BehaviorTree_Group__FieldAccessorTable;
			}
		}

		public const int PersonsFieldNumber = 1;
		private pbc::PopsicleList<global::BehaviorTree.Person> persons_ = new pbc::PopsicleList<global::BehaviorTree.Person>();

		public scg::IList<global::BehaviorTree.Person> PersonsList
		{
			get
			{
				return persons_;
			}
		}

		public int PersonsCount
		{
			get
			{
				return persons_.Count;
			}
		}

		public global::BehaviorTree.Person GetPersons(int index)
		{
			return persons_[index];
		}

		public override bool IsInitialized
		{
			get
			{
				foreach (global::BehaviorTree.Person element in PersonsList)
				{
					if (!element.IsInitialized)
					{
						return false;
					}
				}
				return true;
			}
		}

		public override void WriteTo(pb::ICodedOutputStream output)
		{
			int size = SerializedSize;
			string[] field_names = _groupFieldNames;
			if (persons_.Count > 0)
			{
				output.WriteMessageArray(1, field_names[0], persons_);
			}
			UnknownFields.WriteTo(output);
		}

		private int memoizedSerializedSize = -1;

		public override int SerializedSize
		{
			get
			{
				int size = memoizedSerializedSize;
				if (size != -1)
				{
					return size;
				}

				size = 0;
				foreach (global::BehaviorTree.Person element in PersonsList)
				{
					size += pb::CodedOutputStream.ComputeMessageSize(1, element);
				}
				size += UnknownFields.SerializedSize;
				memoizedSerializedSize = size;
				return size;
			}
		}

		public static Group ParseFrom(pb::ByteString data)
		{
			return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
		}

		public static Group ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
		}

		public static Group ParseFrom(byte[] data)
		{
			return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
		}

		public static Group ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
		}

		public static Group ParseFrom(global::System.IO.Stream input)
		{
			return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
		}

		public static Group ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
		}

		public static Group ParseDelimitedFrom(global::System.IO.Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		public static Group ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		public static Group ParseFrom(pb::ICodedInputStream input)
		{
			return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
		}

		public static Group ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry)
		{
			return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
		}

		private Group MakeReadOnly()
		{
			persons_.MakeReadOnly();
			return this;
		}

		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		public static Builder CreateBuilder(Group prototype)
		{
			return new Builder(prototype);
		}

		[global::System.Diagnostics.DebuggerNonUserCodeAttribute(),
		 global::System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
		 global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    
    
		public sealed partial class Builder : pb::GeneratedBuilder<Group, Builder>
		{
			protected override Builder ThisBuilder
			{
				get
				{
					return this;
				}
			}

			public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			internal Builder(Group cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			private bool resultIsReadOnly;
			private Group result;

			private Group PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					Group original = result;
					result = new Group();
					resultIsReadOnly = false;
					MergeFrom(original);
				}
				return result;
			}

			public override bool IsInitialized
			{
				get
				{
					return result.IsInitialized;
				}
			}

			protected override Group MessageBeingBuilt
			{
				get
				{
					return PrepareBuilder();
				}
			}

			public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				else
				{
					return new Builder().MergeFrom(result);
				}
			}

			public override pbd::MessageDescriptor DescriptorForType
			{
				get
				{
					return global::BehaviorTree.Group.Descriptor;
				}
			}

			public override Group DefaultInstanceForType
			{
				get
				{
					return global::BehaviorTree.Group.DefaultInstance;
				}
			}

			public override Group BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			public override Builder MergeFrom(pb::IMessage other)
			{
				if (other is Group)
				{
					return MergeFrom((Group) other);
				}
				else
				{
					base.MergeFrom(other);
					return this;
				}
			}

			public override Builder MergeFrom(Group other)
			{
				if (other == global::BehaviorTree.Group.DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.persons_.Count != 0)
				{
					result.persons_.Add(other.persons_);
				}
				this.MergeUnknownFields(other.UnknownFields);
				return this;
			}

			public override Builder MergeFrom(pb::ICodedInputStream input)
			{
				return MergeFrom(input, pb::ExtensionRegistry.Empty);
			}

			public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				pb::UnknownFieldSet.Builder unknownFields = null;
				uint tag;
				string field_name;
				while (input.ReadTag(out tag, out field_name))
				{
					if (tag == 0 && field_name != null)
					{
						int field_ordinal = global::System.Array.BinarySearch(
						                                                      _groupFieldNames, field_name,
						                                                      global::System.StringComparer.Ordinal);
						if (field_ordinal >= 0)
						{
							tag = _groupFieldTags[field_ordinal];
						}
						else
						{
							if (unknownFields == null)
							{
								unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
							}
							ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
							continue;
						}
					}
					switch (tag)
					{
						case 0:
						{
							throw pb::InvalidProtocolBufferException.InvalidTag();
						}
						default:
						{
							if (pb::WireFormat.IsEndGroupTag(tag))
							{
								if (unknownFields != null)
								{
									this.UnknownFields = unknownFields.Build();
								}
								return this;
							}
							if (unknownFields == null)
							{
								unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
							}
							ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
							break;
						}
						case 10:
						{
							input.ReadMessageArray(
							                       tag, field_name, result.persons_, global::BehaviorTree.Person.DefaultInstance,
							                       extensionRegistry);
							break;
						}
					}
				}

				if (unknownFields != null)
				{
					this.UnknownFields = unknownFields.Build();
				}
				return this;
			}

			public pbc::IPopsicleList<global::BehaviorTree.Person> PersonsList
			{
				get
				{
					return PrepareBuilder().persons_;
				}
			}

			public int PersonsCount
			{
				get
				{
					return result.PersonsCount;
				}
			}

			public global::BehaviorTree.Person GetPersons(int index)
			{
				return result.GetPersons(index);
			}

			public Builder SetPersons(int index, global::BehaviorTree.Person value)
			{
				pb::ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.persons_[index] = value;
				return this;
			}

			public Builder SetPersons(int index, global::BehaviorTree.Person.Builder builderForValue)
			{
				pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.persons_[index] = builderForValue.Build();
				return this;
			}

			public Builder AddPersons(global::BehaviorTree.Person value)
			{
				pb::ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.persons_.Add(value);
				return this;
			}

			public Builder AddPersons(global::BehaviorTree.Person.Builder builderForValue)
			{
				pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.persons_.Add(builderForValue.Build());
				return this;
			}

			public Builder AddRangePersons(scg::IEnumerable<global::BehaviorTree.Person> values)
			{
				PrepareBuilder();
				result.persons_.Add(values);
				return this;
			}

			public Builder ClearPersons()
			{
				PrepareBuilder();
				result.persons_.Clear();
				return this;
			}
		}

		static Group()
		{
			object.ReferenceEquals(global::BehaviorTree.Proto.Person.Descriptor, null);
		}
	}

	#endregion
}

#endregion Designer generated code