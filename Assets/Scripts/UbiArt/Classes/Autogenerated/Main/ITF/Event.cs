using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class Event : CSerializable {
		public ObjectRef sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR
				|| Settings.s.game == Settings.Game.RO
				|| Settings.s.game == Settings.Game.RFR
				|| Settings.s.game == Settings.Game.RL
				|| Settings.s.game == Settings.Game.COL) {
				sender = (ObjectRef)s.Serialize<uint>((uint)sender, name: "sender");
			} else if(Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					sender = s.SerializeObject<ObjectRef>(sender, name: "sender");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags18 | SerializeFlags.Flags19)) { // 0x0C0000 :thinking:
					sender = s.SerializeObject<ObjectRef>(sender, name: "sender");
				}
			}
		}
		public override uint? ClassCRC => 0x2E0A36E9;
	}
}

