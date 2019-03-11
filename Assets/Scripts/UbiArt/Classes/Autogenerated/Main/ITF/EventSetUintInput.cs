using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetUintInput : Event {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("inputValue")] public uint inputValue;
		[Serialize("sender"    )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(inputName));
				SerializeField(s, nameof(inputValue));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(inputName));
				SerializeField(s, nameof(inputValue));
			} else {
				SerializeField(s, nameof(inputName));
				SerializeField(s, nameof(inputValue));
			}
		}
		public override uint? ClassCRC => 0x603D2117;
	}
}

