using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PlayerConfig_Template : CSerializable {
		[Serialize("minHitPoints"                    )] public uint minHitPoints;
		[Serialize("maxHitPoints"                    )] public uint maxHitPoints;
		[Serialize("startHitPoints"                  )] public uint startHitPoints;
		[Serialize("startHitPointsAfterDeath"        )] public uint startHitPointsAfterDeath;
		[Serialize("maxHitPointsWithPet"             )] public uint maxHitPointsWithPet;
		[Serialize("maxHitPointsWithPetProtector"    )] public uint maxHitPointsWithPetProtector;
		[Serialize("maxHitPointsWithPetProtectorKing")] public uint maxHitPointsWithPetProtectorKing;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minHitPoints));
			SerializeField(s, nameof(maxHitPoints));
			SerializeField(s, nameof(startHitPoints));
			SerializeField(s, nameof(startHitPointsAfterDeath));
			SerializeField(s, nameof(maxHitPointsWithPet));
			SerializeField(s, nameof(maxHitPointsWithPetProtector));
			SerializeField(s, nameof(maxHitPointsWithPetProtectorKing));
		}
	}
}

