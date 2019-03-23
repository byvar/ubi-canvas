using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeFireComponent : ActorComponent {
		[Serialize("distanceFromCheckpoint")] public float distanceFromCheckpoint;
		[Serialize("speedFactor"           )] public float speedFactor;
		[Serialize("hasMoved"              )] public bool hasMoved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(distanceFromCheckpoint));
					SerializeField(s, nameof(speedFactor));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(hasMoved), boolAsByte: true);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(distanceFromCheckpoint));
					SerializeField(s, nameof(speedFactor));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(hasMoved));
				}
			}
		}
		public override uint? ClassCRC => 0x20C65860;
	}
}

