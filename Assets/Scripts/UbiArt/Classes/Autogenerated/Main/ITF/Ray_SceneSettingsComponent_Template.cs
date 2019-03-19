using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_SceneSettingsComponent_Template : CSerializable {
		[Serialize("maxPlayers"        )] public uint maxPlayers;
		[Serialize("allowFriendlyFire" )] public int allowFriendlyFire;
		[Serialize("allowPlayerCrush"  )] public int allowPlayerCrush;
		[Serialize("allowNpcCrush"     )] public int allowNpcCrush;
		[Serialize("invincibleEnemies" )] public int invincibleEnemies;
		[Serialize("enableCheatMode"   )] public int enableCheatMode;
		[Serialize("powerupDive"       )] public int powerupDive;
		[Serialize("powerupWalkOnWalls")] public int powerupWalkOnWalls;
		[Serialize("powerupReduction"  )] public int powerupReduction;
		[Serialize("powerupHelicopter" )] public int powerupHelicopter;
		[Serialize("powerupFight"      )] public int powerupFight;
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

