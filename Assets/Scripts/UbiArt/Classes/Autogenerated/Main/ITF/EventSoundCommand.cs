using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSoundCommand : Event {
		[Serialize("sender"  )] public uint sender;
		[Serialize("commands")] public Placeholder commands;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(commands));
			} else {
			}
		}
		public override uint? ClassCRC => 0xDB5E61B6;
	}
}

