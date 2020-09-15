using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapManagerComponent_Template : ActorComponent_Template {
		public float timeBetweenLums;
		public float timeAppearNewPet;
		public StringID animPlayerDance;
		public Path petPath;
		public uint maxConfetti;
		public float prisonersMinDelayShort;
		public float prisonersMaxDelayShort;
		public float prisonersMinDelayLong;
		public float prisonersMaxDelayLong;
		public Placeholder musicEventPrisonersStart;
		public Placeholder musicEventLowEnd;
		public Placeholder musicEventHighEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				timeBetweenLums = s.Serialize<float>(timeBetweenLums, name: "timeBetweenLums");
				timeAppearNewPet = s.Serialize<float>(timeAppearNewPet, name: "timeAppearNewPet");
				animPlayerDance = s.SerializeObject<StringID>(animPlayerDance, name: "animPlayerDance");
				petPath = s.SerializeObject<Path>(petPath, name: "petPath");
				maxConfetti = s.Serialize<uint>(maxConfetti, name: "maxConfetti");
				prisonersMinDelayShort = s.Serialize<float>(prisonersMinDelayShort, name: "prisonersMinDelayShort");
				prisonersMaxDelayShort = s.Serialize<float>(prisonersMaxDelayShort, name: "prisonersMaxDelayShort");
				prisonersMinDelayLong = s.Serialize<float>(prisonersMinDelayLong, name: "prisonersMinDelayLong");
				prisonersMaxDelayLong = s.Serialize<float>(prisonersMaxDelayLong, name: "prisonersMaxDelayLong");
				musicEventPrisonersStart = s.SerializeObject<Placeholder>(musicEventPrisonersStart, name: "musicEventPrisonersStart");
				musicEventLowEnd = s.SerializeObject<Placeholder>(musicEventLowEnd, name: "musicEventLowEnd");
				musicEventHighEnd = s.SerializeObject<Placeholder>(musicEventHighEnd, name: "musicEventHighEnd");
			} else {
				timeBetweenLums = s.Serialize<float>(timeBetweenLums, name: "timeBetweenLums");
				timeAppearNewPet = s.Serialize<float>(timeAppearNewPet, name: "timeAppearNewPet");
				animPlayerDance = s.SerializeObject<StringID>(animPlayerDance, name: "animPlayerDance");
				petPath = s.SerializeObject<Path>(petPath, name: "petPath");
				maxConfetti = s.Serialize<uint>(maxConfetti, name: "maxConfetti");
				prisonersMinDelayShort = s.Serialize<float>(prisonersMinDelayShort, name: "prisonersMinDelayShort");
				prisonersMaxDelayShort = s.Serialize<float>(prisonersMaxDelayShort, name: "prisonersMaxDelayShort");
				prisonersMinDelayLong = s.Serialize<float>(prisonersMinDelayLong, name: "prisonersMinDelayLong");
				prisonersMaxDelayLong = s.Serialize<float>(prisonersMaxDelayLong, name: "prisonersMaxDelayLong");
			}
		}
		public override uint? ClassCRC => 0x9DA6639F;
	}
}

