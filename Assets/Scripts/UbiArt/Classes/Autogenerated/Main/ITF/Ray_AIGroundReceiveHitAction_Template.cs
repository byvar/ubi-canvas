using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGroundReceiveHitAction_Template : Ray_AIReceiveHitAction_Template {
		[Serialize("unstickMultiplier")] public float unstickMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unstickMultiplier));
		}
		public override uint? ClassCRC => 0x63D01468;
	}
}

