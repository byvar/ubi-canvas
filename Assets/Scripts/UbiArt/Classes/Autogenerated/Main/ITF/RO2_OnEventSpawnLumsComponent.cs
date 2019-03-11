using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_OnEventSpawnLumsComponent : ActorComponent {
		[Serialize("NumberOfLums"      )] public int NumberOfLums;
		[Serialize("disabledAfterEvent")] public bool disabledAfterEvent;
		[Serialize("NumberOfLums"      )] public bool NumberOfLums;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(NumberOfLums));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
				}
			} else {
				SerializeField(s, nameof(NumberOfLums));
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(disabledAfterEvent));
				}
			}
		}
		public override uint? ClassCRC => 0xB3AF30AD;
	}
}

