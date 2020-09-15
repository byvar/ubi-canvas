using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGround_ReceiveInAirHitAction_Template : Ray_AIGroundReceiveHitAction_Template {
		public float gravityMultiplier;
		public float hitForce;
		public float fullAntigravTime;
		public float antigravRampDownTime;
		public int canBlockHits;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
			hitForce = s.Serialize<float>(hitForce, name: "hitForce");
			fullAntigravTime = s.Serialize<float>(fullAntigravTime, name: "fullAntigravTime");
			antigravRampDownTime = s.Serialize<float>(antigravRampDownTime, name: "antigravRampDownTime");
			canBlockHits = s.Serialize<int>(canBlockHits, name: "canBlockHits");
		}
		public override uint? ClassCRC => 0x7EC981D2;
	}
}

