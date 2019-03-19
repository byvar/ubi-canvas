using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PuzzlePieceComponent_Template : ActorComponent_Template {
		[Serialize("lineCount"  )] public uint lineCount;
		[Serialize("columnCount")] public uint columnCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lineCount));
			SerializeField(s, nameof(columnCount));
		}
		public override uint? ClassCRC => 0x224CA0A3;
	}
}

