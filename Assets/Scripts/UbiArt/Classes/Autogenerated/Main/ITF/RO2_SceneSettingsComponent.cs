using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SceneSettingsComponent : ActorComponent {
		[Serialize("unlockedPowerUps")] public RO2_GlobalPowerUpUnlocked unlockedPowerUps;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(unlockedPowerUps));
			}
		}
		public override uint? ClassCRC => 0xBE78973C;
	}
}

