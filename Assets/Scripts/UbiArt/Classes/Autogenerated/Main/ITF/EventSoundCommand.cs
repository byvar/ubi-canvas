using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSoundCommand : Event {
		public CList<Generic<SoundCommand>> commands; // CList<Generic<???>>
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				commands = s.SerializeObject<CList<Generic<SoundCommand>>>(commands, name: "commands");
			} else {
			}
		}
		public override uint? ClassCRC => 0xDB5E61B6;
	}
}

