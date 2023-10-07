namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ChallengeFireComponent : ActorComponent {
		public float distanceFromCheckpoint = 15f;
		public float speedFactor = 1f;
		public bool hasMoved;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
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

