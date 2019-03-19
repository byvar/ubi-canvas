using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGround_ReceiveInAirHitAction_Template : Ray_AIGroundReceiveHitAction_Template {
		[Serialize("gravityMultiplier"   )] public float gravityMultiplier;
		[Serialize("hitForce"            )] public float hitForce;
		[Serialize("fullAntigravTime"    )] public float fullAntigravTime;
		[Serialize("antigravRampDownTime")] public float antigravRampDownTime;
		[Serialize("canBlockHits"        )] public int canBlockHits;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravityMultiplier));
			SerializeField(s, nameof(hitForce));
			SerializeField(s, nameof(fullAntigravTime));
			SerializeField(s, nameof(antigravRampDownTime));
			SerializeField(s, nameof(canBlockHits));
		}
		public override uint? ClassCRC => 0x7EC981D2;
	}
}

