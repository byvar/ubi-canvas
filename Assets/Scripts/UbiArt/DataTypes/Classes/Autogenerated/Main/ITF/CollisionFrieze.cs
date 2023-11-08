namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class CollisionFrieze : CSerializable {
		public bool build;
		public float offset = 0.5f;
		public Vec2d extremity = Vec2d.Infinity;
		public Vec2d extremity2 = Vec2d.Infinity;
		public bool flip;
		public uint methode;
		public float distMaxToSkipParallelEdge = 0.075f;
		public float smoothFactor = float.MaxValue;
		public bool isSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				build = s.Serialize<bool>(build, name: "build");
				offset = s.Serialize<float>(offset, name: "offset");
				extremity = s.SerializeObject<Vec2d>(extremity, name: "extremity");
				extremity2 = s.SerializeObject<Vec2d>(extremity2, name: "extremity2");
				flip = s.Serialize<bool>(flip, name: "flip", options: CSerializerObject.Options.BoolAsByte);
				methode = s.Serialize<uint>(methode, name: "methode");
				distMaxToSkipParallelEdge = s.Serialize<float>(distMaxToSkipParallelEdge, name: "distMaxToSkipParallelEdge");
				smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					isSmooth = s.Serialize<bool>(isSmooth, name: "isSmooth", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				build = s.Serialize<bool>(build, name: "build");
				offset = s.Serialize<float>(offset, name: "offset");
				extremity = s.SerializeObject<Vec2d>(extremity, name: "extremity");
				extremity2 = s.SerializeObject<Vec2d>(extremity2, name: "extremity2");
				flip = s.Serialize<bool>(flip, name: "flip");
				methode = s.Serialize<uint>(methode, name: "methode");
				distMaxToSkipParallelEdge = s.Serialize<float>(distMaxToSkipParallelEdge, name: "distMaxToSkipParallelEdge");
				smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					isSmooth = s.Serialize<bool>(isSmooth, name: "isSmooth");
				}
			}
		}
	}
}

