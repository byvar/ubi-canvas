using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIPerformHitPolylinePunchAction_Template : RO2_AIPerformHitAction_Template {
		public Angle dirOffset;
		public bool hitEnvironment;
		public float memorizeHitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dirOffset = s.SerializeObject<Angle>(dirOffset, name: "dirOffset");
			hitEnvironment = s.Serialize<bool>(hitEnvironment, name: "hitEnvironment");
			memorizeHitTime = s.Serialize<float>(memorizeHitTime, name: "memorizeHitTime");
		}
		public override uint? ClassCRC => 0x77EE31FB;
	}
}

