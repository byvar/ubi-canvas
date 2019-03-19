using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventSequenceFade : Event {
		[Serialize("name"    )] public StringID name;
		[Serialize("isFadeIn")] public bool isFadeIn;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(isFadeIn));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(isFadeIn));
			}
		}
		public override uint? ClassCRC => 0x3A768F0A;
	}
}

