using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RuleStat : CSerializable {
		public Enum_action action;
		public string actionName;
		public Enum_valueType valueType;
		public int intValue;
		public float floatValue;
		public string stringValue;
		public bool boolValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			action = s.Serialize<Enum_action>(action, name: "action");
			actionName = s.Serialize<string>(actionName, name: "actionName");
			valueType = s.Serialize<Enum_valueType>(valueType, name: "valueType");
			intValue = s.Serialize<int>(intValue, name: "intValue");
			floatValue = s.Serialize<float>(floatValue, name: "floatValue");
			stringValue = s.Serialize<string>(stringValue, name: "stringValue");
			boolValue = s.Serialize<bool>(boolValue, name: "boolValue");
		}
		public enum Enum_action {
			[Serialize("Custom" )] Custom = 0,
			[Serialize("Trigger")] Trigger = 1,
			[Serialize("Set"    )] Set = 2,
			[Serialize("Add"    )] Add = 3,
			[Serialize("Max"    )] Max = 4,
			[Serialize("Min"    )] Min = 5,
		}
		public enum Enum_valueType {
			[Serialize("None"             )] None = 0,
			[Serialize("Int"              )] Int = 1,
			[Serialize("Float"            )] Float = 2,
			[Serialize("Bool"             )] Bool = 3,
			[Serialize("String"           )] String = 4,
			[Serialize("Attribute"        )] Attribute = 5,
			[Serialize("InterpretedString")] InterpretedString = 6,
		}
	}
}

