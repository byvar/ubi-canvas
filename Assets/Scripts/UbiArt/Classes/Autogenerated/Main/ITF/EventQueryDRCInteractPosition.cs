using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class EventQueryDRCInteractPosition : Event {
		[Serialize("position")] public Vector2 position;
		[Serialize("sender"  )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(position));
			} else {
				SerializeField(s, nameof(position));
			}
		}
		public override uint? ClassCRC => 0x03B0E285;
	}
}

