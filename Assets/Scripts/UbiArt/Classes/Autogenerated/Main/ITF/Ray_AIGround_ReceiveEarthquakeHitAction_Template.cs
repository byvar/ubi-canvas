using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIGround_ReceiveEarthquakeHitAction_Template : Ray_AIGround_ReceiveNormalHitAction_Template {
		[Serialize("ejectProbability")] public float ejectProbability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectProbability));
		}
		public override uint? ClassCRC => 0x67FD07B2;
	}
}

