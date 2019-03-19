using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSequenceActorActivate : Event {
		[Serialize("activate")] public bool activate;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
			} else {
				SerializeField(s, nameof(activate));
			}
		}
		public override uint? ClassCRC => 0x42BB4EF3;
	}
}

