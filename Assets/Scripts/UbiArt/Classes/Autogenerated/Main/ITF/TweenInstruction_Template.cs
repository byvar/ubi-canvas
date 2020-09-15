using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TweenInstruction_Template : CSerializable {
		public float duration;
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			duration = s.Serialize<float>(duration, name: "duration");
			name = s.SerializeObject<StringID>(name, name: "name");
		}
		public override uint? ClassCRC => 0xF14825EE;
	}
}

