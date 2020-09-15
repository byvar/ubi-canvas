using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MazePortalComponent_Template : ActorComponent_Template {
		public float exitForce;
		public float radius;
		public float exitSpeed;
		public float maxFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			exitForce = s.Serialize<float>(exitForce, name: "exitForce");
			radius = s.Serialize<float>(radius, name: "radius");
			exitSpeed = s.Serialize<float>(exitSpeed, name: "exitSpeed");
			maxFactor = s.Serialize<float>(maxFactor, name: "maxFactor");
		}
		public override uint? ClassCRC => 0xB1E3FAC8;
	}
}

