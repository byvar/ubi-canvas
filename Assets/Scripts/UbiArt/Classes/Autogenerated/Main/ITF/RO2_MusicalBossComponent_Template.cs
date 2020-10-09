using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MusicalBossComponent_Template : ActorComponent_Template {
		public uint faction;
		public uint metronomeType;
		public Path tutoPath;
		public Vec3d tutoPos;
		public float tutoDuration;
		public uint tutoDisplayCount;
		public uint pulseFactor;
		public float alphaA;
		public float alphaB;
		public float alphaFactorWhenWaiting;
		public float ySmooth;
		public Generic<Event> musicEvent;
		public Generic<Event> deathMusicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				faction = s.Serialize<uint>(faction, name: "faction");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				tutoPath = s.SerializeObject<Path>(tutoPath, name: "tutoPath");
				tutoPos = s.SerializeObject<Vec3d>(tutoPos, name: "tutoPos");
				tutoDuration = s.Serialize<float>(tutoDuration, name: "tutoDuration");
				tutoDisplayCount = s.Serialize<uint>(tutoDisplayCount, name: "tutoDisplayCount");
				pulseFactor = s.Serialize<uint>(pulseFactor, name: "pulseFactor");
				alphaA = s.Serialize<float>(alphaA, name: "alphaA");
				alphaB = s.Serialize<float>(alphaB, name: "alphaB");
				alphaFactorWhenWaiting = s.Serialize<float>(alphaFactorWhenWaiting, name: "alphaFactorWhenWaiting");
				ySmooth = s.Serialize<float>(ySmooth, name: "ySmooth");
				musicEvent = s.SerializeObject<Generic<Event>>(musicEvent, name: "musicEvent");
				deathMusicEvent = s.SerializeObject<Generic<Event>>(deathMusicEvent, name: "deathMusicEvent");
			} else {
				faction = s.Serialize<uint>(faction, name: "faction");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				tutoPath = s.SerializeObject<Path>(tutoPath, name: "tutoPath");
				tutoPos = s.SerializeObject<Vec3d>(tutoPos, name: "tutoPos");
				tutoDuration = s.Serialize<float>(tutoDuration, name: "tutoDuration");
				tutoDisplayCount = s.Serialize<uint>(tutoDisplayCount, name: "tutoDisplayCount");
				pulseFactor = s.Serialize<uint>(pulseFactor, name: "pulseFactor");
				alphaA = s.Serialize<float>(alphaA, name: "alphaA");
				alphaB = s.Serialize<float>(alphaB, name: "alphaB");
				alphaFactorWhenWaiting = s.Serialize<float>(alphaFactorWhenWaiting, name: "alphaFactorWhenWaiting");
				ySmooth = s.Serialize<float>(ySmooth, name: "ySmooth");
			}
		}
		public override uint? ClassCRC => 0x8EB5315B;
	}
}

