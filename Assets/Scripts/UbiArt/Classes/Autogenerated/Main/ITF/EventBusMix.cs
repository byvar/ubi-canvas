using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventBusMix : Event {
		[Serialize("sender"  )] public uint sender;
		[Serialize("activate")] public bool activate;
		[Serialize("busMix"  )] public Placeholder busMix;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(busMix));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(activate));
				SerializeField(s, nameof(busMix));
			} else {
			}
		}
		public override uint? ClassCRC => 0xAEA6BBF0;
	}
}

