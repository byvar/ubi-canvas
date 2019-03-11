using UnityEngine;

namespace UbiArt.ITF {
	public partial class Event : CSerializable {
		[Serialize("sender")] public ObjectRef sender;
		[Serialize("sender")] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
			} else {
				if (s.HasFlags(SerializeFlags.Flags18 | SerializeFlags.Flags19)) {
					SerializeField(s, nameof(sender));
				}
			}
		}
		public override uint? ClassCRC => 0x2E0A36E9;
	}
}

