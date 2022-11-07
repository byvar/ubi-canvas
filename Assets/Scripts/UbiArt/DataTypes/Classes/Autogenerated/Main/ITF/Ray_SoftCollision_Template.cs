namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SoftCollision_Template : CSerializable {
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

