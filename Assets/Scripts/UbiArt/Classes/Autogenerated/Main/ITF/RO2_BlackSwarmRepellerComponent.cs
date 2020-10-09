using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BlackSwarmRepellerComponent : ActorComponent {
		public float syncOffset;
		public float radiusMax;
		public float radiusMin;
		public float cycleDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
			radiusMax = s.Serialize<float>(radiusMax, name: "radiusMax");
			radiusMin = s.Serialize<float>(radiusMin, name: "radiusMin");
			cycleDuration = s.Serialize<float>(cycleDuration, name: "cycleDuration");
		}
		public override uint? ClassCRC => 0x6ABCB410;
	}
}

