using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_Sum : CSerializable {
		public StringID typeToGet;
		public uint amountToGet;
		public int currentSessionOnly;
		public int strictlyEqual;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			typeToGet = s.SerializeObject<StringID>(typeToGet, name: "typeToGet");
			amountToGet = s.Serialize<uint>(amountToGet, name: "amountToGet");
			currentSessionOnly = s.Serialize<int>(currentSessionOnly, name: "currentSessionOnly");
			strictlyEqual = s.Serialize<int>(strictlyEqual, name: "strictlyEqual");
		}
		public override uint? ClassCRC => 0x42FFDF60;
	}
}

