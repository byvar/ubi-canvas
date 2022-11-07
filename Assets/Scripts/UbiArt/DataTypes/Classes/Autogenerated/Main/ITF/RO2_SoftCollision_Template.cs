namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RO2_SoftCollision_Template : CSerializable {
		public float radius;
		public float exitSpeed;
		public float exitForce;
		public Vec2d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			radius = s.Serialize<float>(radius, name: "radius");
			exitSpeed = s.Serialize<float>(exitSpeed, name: "exitSpeed");
			exitForce = s.Serialize<float>(exitForce, name: "exitForce");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
		}
	}
}

