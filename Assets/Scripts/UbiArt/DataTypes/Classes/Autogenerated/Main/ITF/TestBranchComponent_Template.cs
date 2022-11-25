namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class TestBranchComponent_Template : BezierBranchComponent_Template {
		public float width = 1f;
		public bool attachToEnd;
		public float tileLength = 1f;
		public CListO<TestSpriteBone> tileBones;
		public float endLength;
		public CListO<TestSpriteBone> endBones;
		public bool drawDebug = true;
		public uint debugMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				width = s.Serialize<float>(width, name: "width");
				attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd", options: CSerializerObject.Options.BoolAsByte);
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				tileBones = s.SerializeObject<CListO<TestSpriteBone>>(tileBones, name: "tileBones");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				endBones = s.SerializeObject<CListO<TestSpriteBone>>(endBones, name: "endBones");
				drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
				debugMode = s.Serialize<uint>(debugMode, name: "debugMode");
			} else {
				width = s.Serialize<float>(width, name: "width");
				attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd");
				tileLength = s.Serialize<float>(tileLength, name: "tileLength");
				tileBones = s.SerializeObject<CListO<TestSpriteBone>>(tileBones, name: "tileBones");
				endLength = s.Serialize<float>(endLength, name: "endLength");
				endBones = s.SerializeObject<CListO<TestSpriteBone>>(endBones, name: "endBones");
				drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
				debugMode = s.Serialize<uint>(debugMode, name: "debugMode");
			}
		}
		public override uint? ClassCRC => 0xC5630DE5;
	}
}

