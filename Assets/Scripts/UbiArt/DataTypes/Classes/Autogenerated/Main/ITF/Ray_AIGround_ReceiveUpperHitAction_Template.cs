using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIGround_ReceiveUpperHitAction_Template : Ray_AIGroundReceiveHitAction_Template {
		public float gravityMultiplier;
		public float hitForce;
		public float fullAntigravTime;
		public float antigravRampDownTime;
		public int canBlockHits;
		public float brakeForce;
		public float brakeHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
			hitForce = s.Serialize<float>(hitForce, name: "hitForce");
			fullAntigravTime = s.Serialize<float>(fullAntigravTime, name: "fullAntigravTime");
			antigravRampDownTime = s.Serialize<float>(antigravRampDownTime, name: "antigravRampDownTime");
			canBlockHits = s.Serialize<int>(canBlockHits, name: "canBlockHits");
			brakeForce = s.Serialize<float>(brakeForce, name: "brakeForce");
			brakeHeight = s.Serialize<float>(brakeHeight, name: "brakeHeight");
		}
		public override uint? ClassCRC => 0xFBF18CB6;
	}
}

