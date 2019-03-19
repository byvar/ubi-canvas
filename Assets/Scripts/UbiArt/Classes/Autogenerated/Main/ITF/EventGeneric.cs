using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL)]
	public partial class EventGeneric : Event {
		[Serialize("id"    )] public StringID id;
		[Serialize("On_Off")] public bool On_Off;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(id));
			} else if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(id));
			} else {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(On_Off));
			}
		}
		public override uint? ClassCRC => 0xF23941DF;
	}
}

