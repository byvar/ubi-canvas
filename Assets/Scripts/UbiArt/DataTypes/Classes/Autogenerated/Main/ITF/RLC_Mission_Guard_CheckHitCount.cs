using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_CheckHitCount : RLC_Mission_Guard {
		public uint hitCount;
		public uint successCondition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hitCount = s.Serialize<uint>(hitCount, name: "hitCount");
			successCondition = s.Serialize<uint>(successCondition, name: "successCondition");
		}
		public override uint? ClassCRC => 0x723ED840;
	}
}

