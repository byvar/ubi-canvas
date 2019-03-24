using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL)]
	public partial class MusicTree_Template : BlendTreeTemplate<MusicTreeResult> {
		[Serialize("metronomeType"  )] public uint metronomeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(metronomeType));
		}
		public override uint? ClassCRC => 0x351957B6;
	}
}

