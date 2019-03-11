using UnityEngine;

namespace UbiArt.ITF {
	public partial class RuleStat : CSerializable {
		[Serialize("action"     )] public Enum_action action;
		[Serialize("actionName" )] public string actionName;
		[Serialize("valueType"  )] public Enum_valueType valueType;
		[Serialize("intValue"   )] public int intValue;
		[Serialize("floatValue" )] public float floatValue;
		[Serialize("stringValue")] public string stringValue;
		[Serialize("boolValue"  )] public bool boolValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(action));
			SerializeField(s, nameof(actionName));
			SerializeField(s, nameof(valueType));
			SerializeField(s, nameof(intValue));
			SerializeField(s, nameof(floatValue));
			SerializeField(s, nameof(stringValue));
			SerializeField(s, nameof(boolValue));
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

