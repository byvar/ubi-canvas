using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicTree_Template : BlendTreeTemplate<Q23ITF15MusicTreeResult> {
		[Serialize("nodes"          )] public Placeholder nodes;
		[Serialize("nodeTransitions")] public Placeholder nodeTransitions;
		[Serialize("metronomeType"  )] public uint metronomeType;
		[Serialize("additiveLayers" )] public Placeholder additiveLayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(nodeTransitions));
				SerializeField(s, nameof(additiveLayers));
				SerializeField(s, nameof(metronomeType));
			} else {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(nodeTransitions));
				SerializeField(s, nameof(metronomeType));
			}
		}
		public override uint? ClassCRC => 0x351957B6;
	}
}

