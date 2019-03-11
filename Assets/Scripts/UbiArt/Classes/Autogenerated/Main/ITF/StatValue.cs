using UnityEngine;

namespace UbiArt.ITF {
	public partial class StatValue : CSerializable {
		[Serialize("type"         )] public Enum_type type;
		[Serialize("stringValue"  )] public string stringValue;
		[Serialize("stringIdValue")] public StringID stringIdValue;
		[Serialize("floatValue"   )] public float floatValue;
		[Serialize("intValue"     )] public int intValue;
		[Serialize("boolValue"    )] public bool boolValue;
		[Serialize("arrayValue"   )] public CList<StatValue> arrayValue;
		[Serialize("objectValue"  )] public CMap<string, StatValue> objectValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(stringValue));
			SerializeField(s, nameof(stringIdValue));
			SerializeField(s, nameof(floatValue));
			SerializeField(s, nameof(intValue));
			SerializeField(s, nameof(boolValue));
			SerializeField(s, nameof(arrayValue));
			SerializeField(s, nameof(objectValue));
		}
		public enum Enum_type {
			[Serialize("Null"    )] Null = 0,
			[Serialize("SInt"    )] SInt = 1,
			[Serialize("UInt"    )] UInt = 2,
			[Serialize("Float"   )] Float = 3,
			[Serialize("Bool"    )] Bool = 4,
			[Serialize("String"  )] String = 5,
			[Serialize("StringId")] StringId = 6,
			[Serialize("Array"   )] Array = 7,
			[Serialize("Object"  )] Object = 8,
		}
	}
}

