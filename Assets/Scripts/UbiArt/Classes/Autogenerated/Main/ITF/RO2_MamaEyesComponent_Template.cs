using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MamaEyesComponent_Template : ActorComponent_Template {
		public Vec3d initSpeed;
		public float gravity;
		public float rotation;
		public float scaleMin;
		public float scaleMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			initSpeed = s.SerializeObject<Vec3d>(initSpeed, name: "initSpeed");
			gravity = s.Serialize<float>(gravity, name: "gravity");
			rotation = s.Serialize<float>(rotation, name: "rotation");
			scaleMin = s.Serialize<float>(scaleMin, name: "scaleMin");
			scaleMax = s.Serialize<float>(scaleMax, name: "scaleMax");
		}
		public override uint? ClassCRC => 0x06481B58;
	}
}

