namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_SlingShotComponent_Template : ActorComponent_Template {
		public Trail_Template TrailTemplate;
		public Path BulletPath;
		public Path BasePath;
		public float BackgroundDistance;
		public float BorderThreeshold;
		public Vec3d murphyOffset;
		public Vec3d SlingShotBase;
		public float SpringDepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TrailTemplate = s.SerializeObject<Trail_Template>(TrailTemplate, name: "TrailTemplate");
			BulletPath = s.SerializeObject<Path>(BulletPath, name: "BulletPath");
			BasePath = s.SerializeObject<Path>(BasePath, name: "BasePath");
			BackgroundDistance = s.Serialize<float>(BackgroundDistance, name: "BackgroundDistance");
			BorderThreeshold = s.Serialize<float>(BorderThreeshold, name: "BorderThreeshold");
			murphyOffset = s.SerializeObject<Vec3d>(murphyOffset, name: "murphyOffset");
			SlingShotBase = s.SerializeObject<Vec3d>(SlingShotBase, name: "SlingShotBase");
			SpringDepthOffset = s.Serialize<float>(SpringDepthOffset, name: "SpringDepthOffset");
		}
		public override uint? ClassCRC => 0x87BB8F23;
	}
}

