using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossJungleComponent : ActorComponent {
		[Serialize("SlowDownDistValidation" )] public float SlowDownDistValidation;
		[Serialize("BaseTimeToReachMaxSpeed")] public float BaseTimeToReachMaxSpeed;
		[Serialize("CheckPointStartIdx"     )] public uint CheckPointStartIdx;
		[Serialize("PhaseIdx"               )] public uint PhaseIdx;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(SlowDownDistValidation));
					SerializeField(s, nameof(BaseTimeToReachMaxSpeed));
					SerializeField(s, nameof(CheckPointStartIdx));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(PhaseIdx));
				}
			} else {
				SerializeField(s, nameof(SlowDownDistValidation));
				SerializeField(s, nameof(BaseTimeToReachMaxSpeed));
				SerializeField(s, nameof(CheckPointStartIdx));
			}
		}
		public override uint? ClassCRC => 0x7082AA30;
	}
}

