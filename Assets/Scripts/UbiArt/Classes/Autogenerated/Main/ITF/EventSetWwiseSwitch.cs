using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL)]
	public partial class EventSetWwiseSwitch : Event {
		[Serialize("WwiseSwitchGroupGUID")] public StringID WwiseSwitchGroupGUID;
		[Serialize("WwiseSwitchGUID"     )] public StringID WwiseSwitchGUID;
		[Serialize("sender"              )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(WwiseSwitchGroupGUID));
				SerializeField(s, nameof(WwiseSwitchGUID));
			} else {
				SerializeField(s, nameof(WwiseSwitchGroupGUID));
				SerializeField(s, nameof(WwiseSwitchGUID));
			}
		}
		public override uint? ClassCRC => 0x87CC5E51;
	}
}

