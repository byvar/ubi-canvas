using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_TestBranchComponent_Template : RO2_BezierBranchComponent_Template {
		public float width;
		public bool attachToEnd;
		public float tileLength;
		public CList<TestSpriteBone> tileBones;
		public float endLength;
		public CList<TestSpriteBone> endBones;
		public bool drawDebug;
		public uint debugMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			width = s.Serialize<float>(width, name: "width");
			attachToEnd = s.Serialize<bool>(attachToEnd, name: "attachToEnd");
			tileLength = s.Serialize<float>(tileLength, name: "tileLength");
			tileBones = s.SerializeObject<CList<TestSpriteBone>>(tileBones, name: "tileBones");
			endLength = s.Serialize<float>(endLength, name: "endLength");
			endBones = s.SerializeObject<CList<TestSpriteBone>>(endBones, name: "endBones");
			drawDebug = s.Serialize<bool>(drawDebug, name: "drawDebug");
			debugMode = s.Serialize<uint>(debugMode, name: "debugMode");
		}
		public override uint? ClassCRC => 0x8417CF08;
	}
}

