using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OnEventSpawnLumsComponent : ActorComponent {
		public int NumberOfLums;
		public bool disabledAfterEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			NumberOfLums = s.Serialize<int>(NumberOfLums, name: "NumberOfLums");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				disabledAfterEvent = s.Serialize<bool>(disabledAfterEvent, name: "disabledAfterEvent");
			}
		}
		public override uint? ClassCRC => 0xB3AF30AD;
	}
}

