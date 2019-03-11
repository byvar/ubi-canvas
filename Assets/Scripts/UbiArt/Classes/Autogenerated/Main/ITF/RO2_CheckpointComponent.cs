using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CheckpointComponent : CheckpointComponent {
		[Serialize("PrimaryPowerUp"             )] public Enum_PrimaryPowerUp PrimaryPowerUp;
		[Serialize("SecondaryPowerUp"           )] public Enum_SecondaryPowerUp SecondaryPowerUp;
		[Serialize("mapPowerup"                 )] public Enum_mapPowerup mapPowerup;
		[Serialize("PrimaryPowerUp"             )] public StringID PrimaryPowerUp;
		[Serialize("SecondaryPowerUp"           )] public StringID SecondaryPowerUp;
		[Serialize("mapPowerup"                 )] public StringID mapPowerup;
		[Serialize("slideMode"                  )] public bool slideMode;
		[Serialize("creatureId"                 )] public StringID creatureId;
		[Serialize("powerupSelectionActive"     )] public bool powerupSelectionActive;
		[Serialize("forceFirstMission"          )] public bool forceFirstMission;
		[Serialize("missionsId"                 )] public CList<StringID> missionsId;
		[Serialize("bOverrideCharPrimitive"     )] public bool bOverrideCharPrimitive;
		[Serialize("overrideCharPrimitiveParams")] public GFXPrimitiveParam overrideCharPrimitiveParams;
		[Serialize("refractionDepthOffset"      )] public float refractionDepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(PrimaryPowerUp));
					SerializeField(s, nameof(SecondaryPowerUp));
					SerializeField(s, nameof(mapPowerup));
					SerializeField(s, nameof(PrimaryPowerUp));
					SerializeField(s, nameof(SecondaryPowerUp));
					SerializeField(s, nameof(mapPowerup));
				}
				SerializeField(s, nameof(slideMode));
				SerializeField(s, nameof(creatureId));
				SerializeField(s, nameof(powerupSelectionActive));
				SerializeField(s, nameof(forceFirstMission));
				SerializeField(s, nameof(missionsId));
				SerializeField(s, nameof(bOverrideCharPrimitive));
				SerializeField(s, nameof(overrideCharPrimitiveParams));
				SerializeField(s, nameof(refractionDepthOffset));
			}
		}
		public enum Enum_PrimaryPowerUp {
		}
		public override uint? ClassCRC => 0x0A060966;
	}
}

