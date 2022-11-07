namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PlayerConfig_Template : CSerializable {
		public uint minHitPoints;
		public uint maxHitPoints;
		public uint startHitPoints;
		public uint startHitPointsAfterDeath;
		public uint maxHitPointsWithPet;
		public uint maxHitPointsWithPetProtector;
		public uint maxHitPointsWithPetProtectorKing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minHitPoints = s.Serialize<uint>(minHitPoints, name: "minHitPoints");
			maxHitPoints = s.Serialize<uint>(maxHitPoints, name: "maxHitPoints");
			startHitPoints = s.Serialize<uint>(startHitPoints, name: "startHitPoints");
			startHitPointsAfterDeath = s.Serialize<uint>(startHitPointsAfterDeath, name: "startHitPointsAfterDeath");
			maxHitPointsWithPet = s.Serialize<uint>(maxHitPointsWithPet, name: "maxHitPointsWithPet");
			maxHitPointsWithPetProtector = s.Serialize<uint>(maxHitPointsWithPetProtector, name: "maxHitPointsWithPetProtector");
			maxHitPointsWithPetProtectorKing = s.Serialize<uint>(maxHitPointsWithPetProtectorKing, name: "maxHitPointsWithPetProtectorKing");
		}
	}
}

