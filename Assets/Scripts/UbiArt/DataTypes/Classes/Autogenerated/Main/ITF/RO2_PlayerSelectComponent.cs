using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PlayerSelectComponent : ShapeComponent {
		public StringID playerId;
		public bool disabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				playerId = s.SerializeObject<StringID>(playerId, name: "playerId");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				disabled = s.Serialize<bool>(disabled, name: "disabled");
			}
		}
		public override uint? ClassCRC => 0xB180E03A;
	}
}

