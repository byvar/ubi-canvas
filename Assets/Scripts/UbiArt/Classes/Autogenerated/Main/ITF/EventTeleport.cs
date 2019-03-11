using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTeleport : Event {
		[Serialize("applyPosAndAngle")] public bool applyPosAndAngle;
		[Serialize("sender"          )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(applyPosAndAngle));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(applyPosAndAngle));
			} else {
				SerializeField(s, nameof(applyPosAndAngle));
			}
		}
		public override uint? ClassCRC => 0x4017E956;
	}
}

