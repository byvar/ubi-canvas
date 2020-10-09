using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BlackSwarmRepellerAIComponent : ActorComponent {
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
		public override uint? ClassCRC => 0x1FD07686;
	}
}

