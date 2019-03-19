using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LeafScrewComponent_Template : RO2_AIComponent_Template {
		[Serialize("animIdle"                 )] public StringID animIdle;
		[Serialize("animImpact"               )] public StringID animImpact;
		[Serialize("animResist"               )] public StringID animResist;
		[Serialize("animCatch"                )] public StringID animCatch;
		[Serialize("animDeath"                )] public StringID animDeath;
		[Serialize("animOut"                  )] public StringID animOut;
		[Serialize("distMaxResist"            )] public float distMaxResist;
		[Serialize("timeMinBeforeOut"         )] public float timeMinBeforeOut;
		[Serialize("zOffset"                  )] public float zOffset;
		[Serialize("angleMaxToSpawn"          )] public Angle angleMaxToSpawn;
		[Serialize("ejectionAngleMax"         )] public Angle ejectionAngleMax;
		[Serialize("ejectionSpeedMin"         )] public float ejectionSpeedMin;
		[Serialize("ejectionSpeedMax"         )] public float ejectionSpeedMax;
		[Serialize("timeBeforeCageGetsCrushed")] public float timeBeforeCageGetsCrushed;
		[Serialize("eyeMinTime"               )] public float eyeMinTime;
		[Serialize("eyeMaxTime"               )] public float eyeMaxTime;
		[Serialize("debug"                    )] public bool debug;
		[Serialize("resistNormMax"            )] public float resistNormMax;
		[Serialize("tutoStopTime"             )] public float tutoStopTime;
		[Serialize("isSpawnMode"              )] public bool isSpawnMode;
		[Serialize("speedMinFastExtract"      )] public float speedMinFastExtract;
		[Serialize("spawnOffset"              )] public Vector2 spawnOffset;
		[Serialize("bounceMultiplier"         )] public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animIdle));
				SerializeField(s, nameof(animImpact));
				SerializeField(s, nameof(animResist));
				SerializeField(s, nameof(animCatch));
				SerializeField(s, nameof(animDeath));
				SerializeField(s, nameof(animOut));
				SerializeField(s, nameof(distMaxResist));
				SerializeField(s, nameof(timeMinBeforeOut));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(angleMaxToSpawn));
				SerializeField(s, nameof(ejectionAngleMax));
				SerializeField(s, nameof(ejectionSpeedMin));
				SerializeField(s, nameof(ejectionSpeedMax));
				SerializeField(s, nameof(eyeMinTime));
				SerializeField(s, nameof(eyeMaxTime));
				SerializeField(s, nameof(debug));
				SerializeField(s, nameof(resistNormMax));
				SerializeField(s, nameof(tutoStopTime));
				SerializeField(s, nameof(isSpawnMode));
				SerializeField(s, nameof(speedMinFastExtract));
				SerializeField(s, nameof(spawnOffset));
				SerializeField(s, nameof(bounceMultiplier));
			} else {
				SerializeField(s, nameof(animIdle));
				SerializeField(s, nameof(animImpact));
				SerializeField(s, nameof(animResist));
				SerializeField(s, nameof(animCatch));
				SerializeField(s, nameof(animDeath));
				SerializeField(s, nameof(animOut));
				SerializeField(s, nameof(distMaxResist));
				SerializeField(s, nameof(timeMinBeforeOut));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(angleMaxToSpawn));
				SerializeField(s, nameof(ejectionAngleMax));
				SerializeField(s, nameof(ejectionSpeedMin));
				SerializeField(s, nameof(ejectionSpeedMax));
				SerializeField(s, nameof(timeBeforeCageGetsCrushed));
				SerializeField(s, nameof(eyeMinTime));
				SerializeField(s, nameof(eyeMaxTime));
				SerializeField(s, nameof(debug));
				SerializeField(s, nameof(resistNormMax));
				SerializeField(s, nameof(tutoStopTime));
				SerializeField(s, nameof(isSpawnMode));
				SerializeField(s, nameof(speedMinFastExtract));
				SerializeField(s, nameof(spawnOffset));
				SerializeField(s, nameof(bounceMultiplier));
			}
		}
		public override uint? ClassCRC => 0x82D476B4;
	}
}

