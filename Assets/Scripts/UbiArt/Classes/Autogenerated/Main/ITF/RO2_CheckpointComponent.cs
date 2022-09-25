using System;
using System.Collections.Generic;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CheckpointComponent : CheckpointComponent {
		public StringID PrimaryPowerUp;
		public StringID SecondaryPowerUp;
		public StringID mapPowerup;
		public bool slideMode;
		public StringID creatureId;
		public bool powerupSelectionActive;
		public bool forceFirstMission;
		public CListO<StringID> missionsId;
		public bool bOverrideCharPrimitive;
		public GFXPrimitiveParam overrideCharPrimitiveParams;
		public float refractionDepthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
			} else {
				if (s.HasFlags(SerializeFlags.Editor)) {
					PrimaryPowerUp = s.SerializeChoiceListObject<StringID>(PrimaryPowerUp, name: "PrimaryPowerUp", choices: PowerUpList);
					SecondaryPowerUp = s.SerializeChoiceListObject<StringID>(SecondaryPowerUp, name: "SecondaryPowerUp", choices: PowerUpList);
					mapPowerup = s.SerializeChoiceListObject<StringID>(mapPowerup, name: "mapPowerup", choices: PowerUpList);
				} else {
					PrimaryPowerUp = s.SerializeObject<StringID>(PrimaryPowerUp, name: "PrimaryPowerUp");
					SecondaryPowerUp = s.SerializeObject<StringID>(SecondaryPowerUp, name: "SecondaryPowerUp");
					mapPowerup = s.SerializeObject<StringID>(mapPowerup, name: "mapPowerup");
				}
				slideMode = s.Serialize<bool>(slideMode, name: "slideMode");
				creatureId = s.SerializeObject<StringID>(creatureId, name: "creatureId");
				powerupSelectionActive = s.Serialize<bool>(powerupSelectionActive, name: "powerupSelectionActive");
				forceFirstMission = s.Serialize<bool>(forceFirstMission, name: "forceFirstMission");
				missionsId = s.SerializeObject<CListO<StringID>>(missionsId, name: "missionsId");
				bOverrideCharPrimitive = s.Serialize<bool>(bOverrideCharPrimitive, name: "bOverrideCharPrimitive");
				overrideCharPrimitiveParams = s.SerializeObject<GFXPrimitiveParam>(overrideCharPrimitiveParams, name: "overrideCharPrimitiveParams");
				refractionDepthOffset = s.Serialize<float>(refractionDepthOffset, name: "refractionDepthOffset");
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

