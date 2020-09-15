using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH)]
	public partial class TweenInstruction : CSerializable {
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
		}
		public override uint? ClassCRC => 0x2AA49880;
	}
}

