using System;
using System.Collections.Generic;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CheckpointComponent : CheckpointComponent {
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
				if (s.HasFlags(SerializeFlags.Editor)) {
					SerializeFieldAsChoiceList(s, nameof(PrimaryPowerUp), choices: PowerUpList);
					SerializeFieldAsChoiceList(s, nameof(SecondaryPowerUp), choices: PowerUpList);
					SerializeFieldAsChoiceList(s, nameof(mapPowerup), choices: PowerUpList);
				} else {
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

		private List<Tuple<string, StringID>> powerUpList;
		public List<Tuple<string, StringID>> PowerUpList {
			get {
				if (powerUpList == null) {
					powerUpList = new List<Tuple<string, StringID>> {
						{ new Tuple<string, StringID>("RLC_PowerUp_None", new StringID("RLC_PowerUp_None")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_DoubleJump", new StringID("RLC_PowerUp_DoubleJump")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Helico", new StringID("RLC_PowerUp_Helico")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Fireball", new StringID("RLC_PowerUp_Fireball")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_FireballActive", new StringID("RLC_PowerUp_FireballActive")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Magnet", new StringID("RLC_PowerUp_Magnet")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Shield", new StringID("RLC_PowerUp_Shield")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Tickle", new StringID("RLC_PowerUp_Tickle")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_AutoAttack", new StringID("RLC_PowerUp_AutoAttack")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Invincibility", new StringID("RLC_PowerUp_Invincibility")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Polymorph", new StringID("RLC_PowerUp_Polymorph")) },
						{ new Tuple<string, StringID>("RLC_PowerUp_Detector", new StringID("RLC_PowerUp_Detector")) },
					};
				}
				return powerUpList;
			}
		}
	}
}

