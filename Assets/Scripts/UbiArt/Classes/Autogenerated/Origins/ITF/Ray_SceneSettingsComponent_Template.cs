using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SceneSettingsComponent_Template : CSerializable {
		[Serialize("maxPlayers"        )] public uint maxPlayers;
		[Serialize("allowFriendlyFire" )] public bool allowFriendlyFire;
		[Serialize("allowPlayerCrush"  )] public bool allowPlayerCrush;
		[Serialize("allowNpcCrush"     )] public bool allowNpcCrush;
		[Serialize("invincibleEnemies" )] public bool invincibleEnemies;
		[Serialize("enableCheatMode"   )] public bool enableCheatMode;
		[Serialize("powerupDive"       )] public bool powerupDive;
		[Serialize("powerupWalkOnWalls")] public bool powerupWalkOnWalls;
		[Serialize("powerupReduction"  )] public bool powerupReduction;
		[Serialize("powerupHelicopter" )] public bool powerupHelicopter;
		[Serialize("powerupFight"      )] public bool powerupFight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxPlayers));
			SerializeField(s, nameof(allowFriendlyFire));
			SerializeField(s, nameof(allowPlayerCrush));
			SerializeField(s, nameof(allowNpcCrush));
			SerializeField(s, nameof(invincibleEnemies));
			SerializeField(s, nameof(enableCheatMode));
			SerializeField(s, nameof(powerupDive));
			SerializeField(s, nameof(powerupWalkOnWalls));
			SerializeField(s, nameof(powerupReduction));
			SerializeField(s, nameof(powerupHelicopter));
			SerializeField(s, nameof(powerupFight));
		}
		public override uint? ClassCRC => 0x6C70138C;
	}
}

