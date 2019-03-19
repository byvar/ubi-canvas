using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_275_sub_8F3350 : CSerializable {
		[Serialize("nodes"          )] public Placeholder nodes;
		[Serialize("nodeTransitions")] public Placeholder nodeTransitions;
		[Serialize("additiveLayers" )] public Placeholder additiveLayers;
		[Serialize("metronomeType"  )] public uint metronomeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nodes));
			SerializeField(s, nameof(nodeTransitions));
			SerializeField(s, nameof(additiveLayers));
			SerializeField(s, nameof(metronomeType));
		}
		public override uint? ClassCRC => 0x351957B6;
	}
}

