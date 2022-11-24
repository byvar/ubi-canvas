namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class CollisionTexture : CSerializable {
		public uint build = 0xFFFFFFFF;
		public float offset = 3.402823e+38F;
		public Vec2d cornerIn = new Vec2d(3.402823e+38F, 3.402823e+38F);
		public Vec2d cornerOut = new Vec2d(3.402823e+38F, 3.402823e+38F);
		public bool cornerInCur;
		public bool cornerOutCur;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			build = s.Serialize<uint>(build, name: "build");
			offset = s.Serialize<float>(offset, name: "offset");
			cornerIn = s.SerializeObject<Vec2d>(cornerIn, name: "cornerIn");
			cornerOut = s.SerializeObject<Vec2d>(cornerOut, name: "cornerOut");
			if (s.HasFlags(SerializeFlags.Flags10)) {
				cornerInCur = s.Serialize<bool>(cornerInCur, name: "cornerInCur");
				cornerOutCur = s.Serialize<bool>(cornerOutCur, name: "cornerOutCur");
			}
		}
	}
}

