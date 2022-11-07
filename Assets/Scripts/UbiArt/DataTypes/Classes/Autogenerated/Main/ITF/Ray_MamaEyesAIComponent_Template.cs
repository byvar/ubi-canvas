namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MamaEyesAIComponent_Template : Ray_AIComponent_Template {
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
		public override uint? ClassCRC => 0x94F888C1;
	}
}

