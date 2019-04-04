using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MusicalBossComponent_Template : ActorComponent_Template {
		[Serialize("faction"               )] public uint faction;
		[Serialize("metronomeType"         )] public uint metronomeType;
		[Serialize("tutoPath"              )] public Path tutoPath;
		[Serialize("tutoPos"               )] public Vector3 tutoPos;
		[Serialize("tutoDuration"          )] public float tutoDuration;
		[Serialize("tutoDisplayCount"      )] public uint tutoDisplayCount;
		[Serialize("pulseFactor"           )] public uint pulseFactor;
		[Serialize("alphaA"                )] public float alphaA;
		[Serialize("alphaB"                )] public float alphaB;
		[Serialize("alphaFactorWhenWaiting")] public float alphaFactorWhenWaiting;
		[Serialize("ySmooth"               )] public float ySmooth;
		[Serialize("musicEvent"            )] public Generic<Event> musicEvent;
		[Serialize("deathMusicEvent"       )] public Generic<Event> deathMusicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(tutoPath));
				SerializeField(s, nameof(tutoPos));
				SerializeField(s, nameof(tutoDuration));
				SerializeField(s, nameof(tutoDisplayCount));
				SerializeField(s, nameof(pulseFactor));
				SerializeField(s, nameof(alphaA));
				SerializeField(s, nameof(alphaB));
				SerializeField(s, nameof(alphaFactorWhenWaiting));
				SerializeField(s, nameof(ySmooth));
				SerializeField(s, nameof(musicEvent));
				SerializeField(s, nameof(deathMusicEvent));
			} else {
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(tutoPath));
				SerializeField(s, nameof(tutoPos));
				SerializeField(s, nameof(tutoDuration));
				SerializeField(s, nameof(tutoDisplayCount));
				SerializeField(s, nameof(pulseFactor));
				SerializeField(s, nameof(alphaA));
				SerializeField(s, nameof(alphaB));
				SerializeField(s, nameof(alphaFactorWhenWaiting));
				SerializeField(s, nameof(ySmooth));
			}
		}
		public override uint? ClassCRC => 0x8EB5315B;
	}
}

