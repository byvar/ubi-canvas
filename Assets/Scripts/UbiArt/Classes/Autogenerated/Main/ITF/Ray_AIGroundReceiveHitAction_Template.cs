using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIGroundReceiveHitAction_Template : Ray_AIReceiveHitAction_Template {
		public float unstickMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			unstickMultiplier = s.Serialize<float>(unstickMultiplier, name: "unstickMultiplier");
		}
		public override uint? ClassCRC => 0x63D01468;
	}
}

