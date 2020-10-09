using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIGround_ReceiveEarthquakeHitAction_Template : Ray_AIGround_ReceiveNormalHitAction_Template {
		public float ejectProbability;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectProbability = s.Serialize<float>(ejectProbability, name: "ejectProbability");
		}
		public override uint? ClassCRC => 0x67FD07B2;
	}
}

