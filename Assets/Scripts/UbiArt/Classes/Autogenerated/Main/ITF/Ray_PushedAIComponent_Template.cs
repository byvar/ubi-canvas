using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_PushedAIComponent_Template : Ray_AIComponent_Template {
		public uint faction2;
		public float forceMultiplier;
		public float maxSpeed;
		public float bounceMultiplier;
		public float weakHitForce;
		public float strongHitForce;
		public float landForceMultiplier;
		public float landXForceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			faction2 = s.Serialize<uint>(faction2, name: "faction");
			forceMultiplier = s.Serialize<float>(forceMultiplier, name: "forceMultiplier");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			weakHitForce = s.Serialize<float>(weakHitForce, name: "weakHitForce");
			strongHitForce = s.Serialize<float>(strongHitForce, name: "strongHitForce");
			landForceMultiplier = s.Serialize<float>(landForceMultiplier, name: "landForceMultiplier");
			landXForceMultiplier = s.Serialize<float>(landXForceMultiplier, name: "landXForceMultiplier");
		}
		public override uint? ClassCRC => 0x1FE64923;
	}
}

