using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetUintInput : Event {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("inputValue")] public uint inputValue;
		[Serialize("sender"    )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
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

