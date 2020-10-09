using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimTreeNodeSequence_Template : BlendTreeNodeBlend_Template<AnimTreeResult> {
		public int loopCount;
		public bool randomizeLoopCount;
		public uint randomLoopCountMax;
		public uint randomLoopCountMin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			loopCount = s.Serialize<int>(loopCount, name: "loopCount");
			randomizeLoopCount = s.Serialize<bool>(randomizeLoopCount, name: "randomizeLoopCount");
			randomLoopCountMax = s.Serialize<uint>(randomLoopCountMax, name: "randomLoopCountMax");
			randomLoopCountMin = s.Serialize<uint>(randomLoopCountMin, name: "randomLoopCountMin");
		}
		public override uint? ClassCRC => 0x355CE175;
	}
}

