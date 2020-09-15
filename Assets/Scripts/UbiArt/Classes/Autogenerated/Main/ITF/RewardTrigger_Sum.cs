using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class RewardTrigger_Sum : RewardTrigger_Base {
		public StringID typeToGet;
		public uint amountToGet;
		public bool currentSessionOnly;
		public bool strictlyEqual;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			typeToGet = s.SerializeObject<StringID>(typeToGet, name: "typeToGet");
			amountToGet = s.Serialize<uint>(amountToGet, name: "amountToGet");
			currentSessionOnly = s.Serialize<bool>(currentSessionOnly, name: "currentSessionOnly");
			strictlyEqual = s.Serialize<bool>(strictlyEqual, name: "strictlyEqual");
		}
		public override uint? ClassCRC => 0x9ED03AF7;
	}
}

