using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeFireComponent : ActorComponent {
		public float distanceFromCheckpoint;
		public float speedFactor;
		public bool hasMoved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					distanceFromCheckpoint = s.Serialize<float>(distanceFromCheckpoint, name: "distanceFromCheckpoint");
					speedFactor = s.Serialize<float>(speedFactor, name: "speedFactor");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					hasMoved = s.Serialize<bool>(hasMoved, name: "hasMoved", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					distanceFromCheckpoint = s.Serialize<float>(distanceFromCheckpoint, name: "distanceFromCheckpoint");
					speedFactor = s.Serialize<float>(speedFactor, name: "speedFactor");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					hasMoved = s.Serialize<bool>(hasMoved, name: "hasMoved");
				}
			}
		}
		public override uint? ClassCRC => 0x20C65860;
	}
}

