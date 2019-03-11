using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_PushedAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("faction"             )] public uint faction;
		[Serialize("forceMultiplier"     )] public float forceMultiplier;
		[Serialize("maxSpeed"            )] public float maxSpeed;
		[Serialize("bounceMultiplier"    )] public float bounceMultiplier;
		[Serialize("weakHitForce"        )] public float weakHitForce;
		[Serialize("strongHitForce"      )] public float strongHitForce;
		[Serialize("landForceMultiplier" )] public float landForceMultiplier;
		[Serialize("landXForceMultiplier")] public float landXForceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(forceMultiplier));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(bounceMultiplier));
			SerializeField(s, nameof(weakHitForce));
			SerializeField(s, nameof(strongHitForce));
			SerializeField(s, nameof(landForceMultiplier));
			SerializeField(s, nameof(landXForceMultiplier));
		}
		public override uint? ClassCRC => 0x1FE64923;
	}
}

