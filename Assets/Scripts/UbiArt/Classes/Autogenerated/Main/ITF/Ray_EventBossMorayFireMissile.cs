using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventBossMorayFireMissile : Event {
		public uint bodyPartIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bodyPartIndex = s.Serialize<uint>(bodyPartIndex, name: "bodyPartIndex");
		}
		public override uint? ClassCRC => 0x749AD6ED;
	}
}

