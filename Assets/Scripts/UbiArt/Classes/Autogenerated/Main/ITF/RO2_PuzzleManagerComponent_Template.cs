using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PuzzleManagerComponent_Template : ActorComponent_Template {
		public bool debugDraw;
		public float caseLength;
		public float caseHeight;
		public uint lineCount;
		public uint columnCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			debugDraw = s.Serialize<bool>(debugDraw, name: "debugDraw");
			caseLength = s.Serialize<float>(caseLength, name: "caseLength");
			caseHeight = s.Serialize<float>(caseHeight, name: "caseHeight");
			lineCount = s.Serialize<uint>(lineCount, name: "lineCount");
			columnCount = s.Serialize<uint>(columnCount, name: "columnCount");
		}
		public override uint? ClassCRC => 0xFE44A3D7;
	}
}

