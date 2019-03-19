using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSoundCommand : Event {
		[Serialize("sender"  )] public uint sender;
		[Serialize("commands")] public Placeholder commands;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(commands));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
			} else {
			}
		}
		public override uint? ClassCRC => 0xDB5E61B6;
	}
}

