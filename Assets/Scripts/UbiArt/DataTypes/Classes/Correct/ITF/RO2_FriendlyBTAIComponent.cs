namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_FriendlyBTAIComponent : BTAIComponent {
		public Path path;
		public Prisoner prisonerVisualType;
		public Enum_prisonerType prisonerType;
		public Index prisonerIndexType;
		public bool canReceiveHits = true;
		public ObjectPath targetWaypoint;
		public ObjectPath respawnPoint;
		public bool rescued;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					path = s.SerializeObject<Path>(path, name: "path");
					prisonerVisualType = s.Serialize<Prisoner>(prisonerVisualType, name: "prisonerVisualType");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					prisonerType = s.Serialize<Enum_prisonerType>(prisonerType, name: "prisonerType");
					prisonerIndexType = s.Serialize<Index>(prisonerIndexType, name: "prisonerIndexType");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					targetWaypoint = s.SerializeObject<ObjectPath>(targetWaypoint, name: "targetWaypoint");
					respawnPoint = s.SerializeObject<ObjectPath>(respawnPoint, name: "respawnPoint");
					rescued = s.Serialize<bool>(rescued, name: "rescued");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					path = s.SerializeObject<Path>(path, name: "path");
					prisonerVisualType = s.Serialize<Prisoner>(prisonerVisualType, name: "prisonerVisualType");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					prisonerType = s.Serialize<Enum_prisonerType>(prisonerType, name: "prisonerType");
					prisonerIndexType = s.Serialize<Index>(prisonerIndexType, name: "prisonerIndexType");
					canReceiveHits = s.Serialize<bool>(canReceiveHits, name: "canReceiveHits");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					targetWaypoint = s.SerializeObject<ObjectPath>(targetWaypoint, name: "targetWaypoint");
					respawnPoint = s.SerializeObject<ObjectPath>(respawnPoint, name: "respawnPoint");
					rescued = s.Serialize<bool>(rescued, name: "rescued");
				}
			}
		}
		public enum Prisoner {
			[Serialize("Prisoner_Soldier" )] Soldier = 0,
			[Serialize("Prisoner_Baby"    )] Baby = 1,
			[Serialize("Prisoner_Fool"    )] Fool = 2,
			[Serialize("Prisoner_Princess")] Princess = 3,
			[Serialize("Prisoner_Prince"  )] Prince = 4,
			[Serialize("Prisoner_Queen"   )] Queen = 5,
			[Serialize("Prisoner_King"    )] King = 6,
		}
		public enum Enum_prisonerType {
			[Serialize("None"        )] None = 0,
			[Serialize("Rope"        )] Rope = 1,
			[Serialize("Pole"        )] Pole = 2,
			[Serialize("Cage1"       )] Cage1 = 3,
			[Serialize("Cage2"       )] Cage2 = 4,
			[Serialize("Torture_Hit" )] Torture_Hit = 5,
			[Serialize("Torture_Jump")] Torture_Jump = 6,
			[Serialize("Bullet"      )] Bullet = 7,
		}
		public enum Index {
			[Serialize("Index_Map1")] Map1 = 0,
			[Serialize("Index_Map2")] Map2 = 1,
			[Serialize("Index_Map3")] Map3 = 2,
			[Serialize("Index_Map4")] Map4 = 3,
			[Serialize("Index_Map5")] Map5 = 4,
			[Serialize("Index_Map6")] Map6 = 5,
			[Serialize("Index_Map7")] Map7 = 6,
			[Serialize("Index_Map8")] Map8 = 7,
		}
		public override uint? ClassCRC => 0x2FBA13A8;
	}
}

