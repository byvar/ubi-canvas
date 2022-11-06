using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossShieldComponent : ActorComponent {
		public bool startOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startOn = s.Serialize<bool>(startOn, name: "startOn");
			}
		}
		public override uint? ClassCRC => 0xD7D7E6DF;
	}
}

