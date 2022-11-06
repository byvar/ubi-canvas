using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_CheckActiveTime : RLC_Mission_Guard {
		public float activeTime;
		public uint successCondition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activeTime = s.Serialize<float>(activeTime, name: "activeTime");
			successCondition = s.Serialize<uint>(successCondition, name: "successCondition");
		}
		public override uint? ClassCRC => 0xBFFCDED0;
	}
}

