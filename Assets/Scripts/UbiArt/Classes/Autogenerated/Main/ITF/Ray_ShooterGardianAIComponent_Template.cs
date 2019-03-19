using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterGardianAIComponent_Template : Ray_SimpleAIComponent_Template {
		[Serialize("minHitStunLevel"           )] public uint minHitStunLevel;
		[Serialize("multiPlayerLifePointFactor")] public float multiPlayerLifePointFactor;
		[Serialize("deathRewardSpawnPath"      )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"         )] public uint deathRewardNumber;
		[Serialize("deathRewardSpawnDuration"  )] public float deathRewardSpawnDuration;
		[Serialize("deathRewardSpawnDist"      )] public Vector2 deathRewardSpawnDist;
		[Serialize("deathRewardSpawnAngle"     )] public Vector2 deathRewardSpawnAngle;
		[Serialize("uint__0"                   )] public uint uint__0;
		[Serialize("float__1"                  )] public float float__1;
		[Serialize("Path__2"                   )] public Path Path__2;
		[Serialize("uint__3"                   )] public uint uint__3;
		[Serialize("float__4"                  )] public float float__4;
		[Serialize("Vector2__5"                )] public Vector2 Vector2__5;
		[Serialize("Vector2__6"                )] public Vector2 Vector2__6;
		[Serialize("Path__7"                   )] public Path Path__7;
		[Serialize("StringID__8"               )] public StringID StringID__8;
		[Serialize("uint__9"                   )] public uint uint__9;
		[Serialize("float__10"                 )] public float float__10;
		[Serialize("float__11"                 )] public float float__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(minHitStunLevel));
				SerializeField(s, nameof(multiPlayerLifePointFactor));
				SerializeField(s, nameof(deathRewardSpawnPath));
				SerializeField(s, nameof(deathRewardNumber));
				SerializeField(s, nameof(deathRewardSpawnDuration));
				SerializeField(s, nameof(deathRewardSpawnDist));
				SerializeField(s, nameof(deathRewardSpawnAngle));
			} else {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(Path__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(Vector2__5));
				SerializeField(s, nameof(Vector2__6));
				SerializeField(s, nameof(Path__7));
				SerializeField(s, nameof(StringID__8));
				SerializeField(s, nameof(uint__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
			}
		}
		public override uint? ClassCRC => 0xA7CBA488;
	}
}

