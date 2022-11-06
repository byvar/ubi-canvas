using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LeafScrewComponent_Template : RO2_AIComponent_Template {
		public StringID animIdle;
		public StringID animImpact;
		public StringID animResist;
		public StringID animCatch;
		public StringID animDeath;
		public StringID animOut;
		public float distMaxResist;
		public float timeMinBeforeOut;
		public float zOffset;
		public Angle angleMaxToSpawn;
		public Angle ejectionAngleMax;
		public float ejectionSpeedMin;
		public float ejectionSpeedMax;
		public float timeBeforeCageGetsCrushed;
		public float eyeMinTime;
		public float eyeMaxTime;
		public bool debug;
		public float resistNormMax;
		public float tutoStopTime;
		public bool isSpawnMode;
		public float speedMinFastExtract;
		public Vec2d spawnOffset;
		public float bounceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
				animImpact = s.SerializeObject<StringID>(animImpact, name: "animImpact");
				animResist = s.SerializeObject<StringID>(animResist, name: "animResist");
				animCatch = s.SerializeObject<StringID>(animCatch, name: "animCatch");
				animDeath = s.SerializeObject<StringID>(animDeath, name: "animDeath");
				animOut = s.SerializeObject<StringID>(animOut, name: "animOut");
				distMaxResist = s.Serialize<float>(distMaxResist, name: "distMaxResist");
				timeMinBeforeOut = s.Serialize<float>(timeMinBeforeOut, name: "timeMinBeforeOut");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				angleMaxToSpawn = s.SerializeObject<Angle>(angleMaxToSpawn, name: "angleMaxToSpawn");
				ejectionAngleMax = s.SerializeObject<Angle>(ejectionAngleMax, name: "ejectionAngleMax");
				ejectionSpeedMin = s.Serialize<float>(ejectionSpeedMin, name: "ejectionSpeedMin");
				ejectionSpeedMax = s.Serialize<float>(ejectionSpeedMax, name: "ejectionSpeedMax");
				eyeMinTime = s.Serialize<float>(eyeMinTime, name: "eyeMinTime");
				eyeMaxTime = s.Serialize<float>(eyeMaxTime, name: "eyeMaxTime");
				debug = s.Serialize<bool>(debug, name: "debug");
				resistNormMax = s.Serialize<float>(resistNormMax, name: "resistNormMax");
				tutoStopTime = s.Serialize<float>(tutoStopTime, name: "tutoStopTime");
				isSpawnMode = s.Serialize<bool>(isSpawnMode, name: "isSpawnMode");
				speedMinFastExtract = s.Serialize<float>(speedMinFastExtract, name: "speedMinFastExtract");
				spawnOffset = s.SerializeObject<Vec2d>(spawnOffset, name: "spawnOffset");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			} else {
				animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
				animImpact = s.SerializeObject<StringID>(animImpact, name: "animImpact");
				animResist = s.SerializeObject<StringID>(animResist, name: "animResist");
				animCatch = s.SerializeObject<StringID>(animCatch, name: "animCatch");
				animDeath = s.SerializeObject<StringID>(animDeath, name: "animDeath");
				animOut = s.SerializeObject<StringID>(animOut, name: "animOut");
				distMaxResist = s.Serialize<float>(distMaxResist, name: "distMaxResist");
				timeMinBeforeOut = s.Serialize<float>(timeMinBeforeOut, name: "timeMinBeforeOut");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				angleMaxToSpawn = s.SerializeObject<Angle>(angleMaxToSpawn, name: "angleMaxToSpawn");
				ejectionAngleMax = s.SerializeObject<Angle>(ejectionAngleMax, name: "ejectionAngleMax");
				ejectionSpeedMin = s.Serialize<float>(ejectionSpeedMin, name: "ejectionSpeedMin");
				ejectionSpeedMax = s.Serialize<float>(ejectionSpeedMax, name: "ejectionSpeedMax");
				timeBeforeCageGetsCrushed = s.Serialize<float>(timeBeforeCageGetsCrushed, name: "timeBeforeCageGetsCrushed");
				eyeMinTime = s.Serialize<float>(eyeMinTime, name: "eyeMinTime");
				eyeMaxTime = s.Serialize<float>(eyeMaxTime, name: "eyeMaxTime");
				debug = s.Serialize<bool>(debug, name: "debug");
				resistNormMax = s.Serialize<float>(resistNormMax, name: "resistNormMax");
				tutoStopTime = s.Serialize<float>(tutoStopTime, name: "tutoStopTime");
				isSpawnMode = s.Serialize<bool>(isSpawnMode, name: "isSpawnMode");
				speedMinFastExtract = s.Serialize<float>(speedMinFastExtract, name: "speedMinFastExtract");
				spawnOffset = s.SerializeObject<Vec2d>(spawnOffset, name: "spawnOffset");
				bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
			}
		}
		public override uint? ClassCRC => 0x82D476B4;
	}
}

