using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatValue : CSerializable {
		public Enum_type type;
		public string stringValue;
		public StringID stringIdValue;
		public float floatValue;
		public int intValue;
		public bool boolValue;
		public CList<StatValue> arrayValue;
		public CMap<string, StatValue> objectValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<Enum_type>(type, name: "type");
			stringValue = s.Serialize<string>(stringValue, name: "stringValue");
			stringIdValue = s.SerializeObject<StringID>(stringIdValue, name: "stringIdValue");
			floatValue = s.Serialize<float>(floatValue, name: "floatValue");
			intValue = s.Serialize<int>(intValue, name: "intValue");
			boolValue = s.Serialize<bool>(boolValue, name: "boolValue");
			arrayValue = s.SerializeObject<CList<StatValue>>(arrayValue, name: "arrayValue");
			objectValue = s.SerializeObject<CMap<string, StatValue>>(objectValue, name: "objectValue");
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

