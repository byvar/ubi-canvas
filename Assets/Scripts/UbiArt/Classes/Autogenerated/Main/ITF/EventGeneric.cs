using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL | GameFlags.RAVersion)]
	public partial class EventGeneric : Event {
		public StringID id;
		public bool On_Off;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR
				|| Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL) {
				id = s.SerializeObject<StringID>(id, name: "id");
			} else {
				id = s.SerializeObject<StringID>(id, name: "id");
				On_Off = s.Serialize<bool>(On_Off, name: "On_Off");
			}
		}
		public override uint? ClassCRC => 0xF23941DF;
	}
}

