using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventDisableCollision : Event {
		[Serialize("disable")] public bool disable;
		[Serialize("sender" )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(disable));
			} else {
				SerializeField(s, nameof(disable));
			}
		}
		public override uint? ClassCRC => 0xE02F4F4A;
	}
}

