using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGround_ReceiveUpperHitAction_Template : Ray_AIGroundReceiveHitAction_Template {
		[Serialize("gravityMultiplier"   )] public float gravityMultiplier;
		[Serialize("hitForce"            )] public float hitForce;
		[Serialize("fullAntigravTime"    )] public float fullAntigravTime;
		[Serialize("antigravRampDownTime")] public float antigravRampDownTime;
		[Serialize("canBlockHits"        )] public int canBlockHits;
		[Serialize("brakeForce"          )] public float brakeForce;
		[Serialize("brakeHeight"         )] public float brakeHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravityMultiplier));
			SerializeField(s, nameof(hitForce));
			SerializeField(s, nameof(fullAntigravTime));
			SerializeField(s, nameof(antigravRampDownTime));
			SerializeField(s, nameof(canBlockHits));
			SerializeField(s, nameof(brakeForce));
			SerializeField(s, nameof(brakeHeight));
		}
		public override uint? ClassCRC => 0xFBF18CB6;
	}
}

