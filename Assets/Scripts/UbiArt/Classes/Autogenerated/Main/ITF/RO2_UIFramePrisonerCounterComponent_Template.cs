using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UIFramePrisonerCounterComponent_Template : ActorComponent_Template {
		[Serialize("stand"                  )] public StringID stand;
		[Serialize("shake"                  )] public StringID shake;
		[Serialize("slotTimeInterval"       )] public float slotTimeInterval;
		[Serialize("medalPaths"             )] public CArray<Path> medalPaths;
		[Serialize("medalTransitionDuration")] public float medalTransitionDuration;
		[Serialize("medalOffsets"           )] public Placeholder medalOffsets;
		[Serialize("medalOffsets3Slots"     )] public Placeholder medalOffsets3Slots;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(stand));
				SerializeField(s, nameof(shake));
				SerializeField(s, nameof(slotTimeInterval));
				SerializeField(s, nameof(medalPaths));
				SerializeField(s, nameof(medalOffsets));
				SerializeField(s, nameof(medalOffsets3Slots));
				SerializeField(s, nameof(medalTransitionDuration));
			} else {
				SerializeField(s, nameof(stand));
				SerializeField(s, nameof(shake));
				SerializeField(s, nameof(slotTimeInterval));
				SerializeField(s, nameof(medalPaths));
				SerializeField(s, nameof(medalPaths));
				SerializeField(s, nameof(medalTransitionDuration));
			}
		}
		public override uint? ClassCRC => 0x65F08F2E;
	}
}

