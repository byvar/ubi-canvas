namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class MetaFriezeParams : CSerializable {
		public Path path;
		public Vec3d worldOffset;
		public float localOffset;
		public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			path = s.SerializeObject<Path>(path, name: "path");
			worldOffset = s.SerializeObject<Vec3d>(worldOffset, name: "worldOffset");
			localOffset = s.Serialize<float>(localOffset, name: "localOffset");
			scale = s.Serialize<float>(scale, name: "scale");
		}
	}
}

