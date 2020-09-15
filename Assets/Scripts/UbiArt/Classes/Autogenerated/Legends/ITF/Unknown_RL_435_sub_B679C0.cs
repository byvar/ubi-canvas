using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_435_sub_B679C0 : ActorComponent {
		public bool AMDisplayTuto;
		public StringID AM_MapId;
		public bool activated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.isCatchThemAll) return;
			if (s.HasFlags(SerializeFlags.Default)) {
				AMDisplayTuto = s.Serialize<bool>(AMDisplayTuto, name: "AMDisplayTuto", options: CSerializerObject.Options.BoolAsByte);
				if (s.HasFlags(SerializeFlags.Editor)) {
					AM_MapId = s.SerializeChoiceListObject<StringID>(AM_MapId, name: "AM_MapId", empty: "invalid");
				} else {
					AM_MapId = s.SerializeObject<StringID>(AM_MapId, name: "AM_MapId");
				}
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				activated = s.Serialize<bool>(activated, name: "activated");
			}
		}
		public override uint? ClassCRC => 0xF84EA47C;
	}
}

