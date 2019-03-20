using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class Event : CSerializable {
		[Serialize("sender")] public ObjectRef sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR
				|| Settings.s.game == Settings.Game.RO
				|| Settings.s.game == Settings.Game.RFR
				|| Settings.s.game == Settings.Game.RL
				|| Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender), type: typeof(uint));
			} else if(Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(sender));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags18 | SerializeFlags.Flags19)) { // 0x0C0000 :thinking:
					SerializeField(s, nameof(sender));
				}
			}
		}
		public override uint? ClassCRC => 0x2E0A36E9;
	}
}

