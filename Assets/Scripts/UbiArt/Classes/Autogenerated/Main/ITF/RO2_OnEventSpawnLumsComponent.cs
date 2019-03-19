using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_OnEventSpawnLumsComponent : ActorComponent {
		[Serialize("NumberOfLums"      )] public int NumberOfLums;
		[Serialize("disabledAfterEvent")] public bool disabledAfterEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(NumberOfLums));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(disabledAfterEvent));
			}
		}
		public override uint? ClassCRC => 0xB3AF30AD;
	}
}

