using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Animation3DTreeNodeSequence_Template : BlendTreeNodeBlend_Template<Animation3DTreeResult> {
		[Serialize("loopCount"         )] public int loopCount;
		[Serialize("randomizeLoopCount")] public bool randomizeLoopCount;
		[Serialize("randomLoopCountMax")] public uint randomLoopCountMax;
		[Serialize("randomLoopCountMin")] public uint randomLoopCountMin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(loopCount));
			SerializeField(s, nameof(randomizeLoopCount));
			SerializeField(s, nameof(randomLoopCountMax));
			SerializeField(s, nameof(randomLoopCountMin));
		}
		public override uint? ClassCRC => 0x5EEF6D2C;
	}
}

