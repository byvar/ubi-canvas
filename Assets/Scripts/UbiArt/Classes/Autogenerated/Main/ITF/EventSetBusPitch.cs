using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetBusPitch : Event {
		[Serialize("sender")] public uint sender;
		[Serialize("pitch" )] public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(pitch));
			} else {
			}
		}
		public override uint? ClassCRC => 0x73B21DD0;
	}
}

