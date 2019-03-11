using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIGroundReceiveHitAction_Template : RO2_AIReceiveHitAction_Template {
		[Serialize("unstickMultiplier")] public float unstickMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(unstickMultiplier));
		}
		public override uint? ClassCRC => 0x5AAADA27;
	}
}

