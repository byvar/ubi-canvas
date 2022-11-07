namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CrystalKingAIComponent_Template : Ray_AIComponent_Template {
		public StringID checkMapForUnlock;
		public Path textureFile;
		public float tileLen;
		public Vec3d rayOffsetCrystal;
		public Vec3d rayOffsetStart;
		public float widthA;
		public float widthB;
		public float widthC;
		public float widthD;
		public float speedScroll;
		public float rayZOffset_Part1;
		public float rayZOffset_Part2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			checkMapForUnlock = s.SerializeObject<StringID>(checkMapForUnlock, name: "checkMapForUnlock");
			textureFile = s.SerializeObject<Path>(textureFile, name: "textureFile");
			tileLen = s.Serialize<float>(tileLen, name: "tileLen");
			rayOffsetCrystal = s.SerializeObject<Vec3d>(rayOffsetCrystal, name: "rayOffsetCrystal");
			rayOffsetStart = s.SerializeObject<Vec3d>(rayOffsetStart, name: "rayOffsetStart");
			widthA = s.Serialize<float>(widthA, name: "widthA");
			widthB = s.Serialize<float>(widthB, name: "widthB");
			widthC = s.Serialize<float>(widthC, name: "widthC");
			widthD = s.Serialize<float>(widthD, name: "widthD");
			speedScroll = s.Serialize<float>(speedScroll, name: "speedScroll");
			rayZOffset_Part1 = s.Serialize<float>(rayZOffset_Part1, name: "rayZOffset_Part1");
			rayZOffset_Part2 = s.Serialize<float>(rayZOffset_Part2, name: "rayZOffset_Part2");
		}
		public override uint? ClassCRC => 0x233D667D;
	}
}

