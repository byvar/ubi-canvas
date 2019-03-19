using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ScoreRecapManagerComponent_Template : ActorComponent_Template {
		[Serialize("timeBetweenLums"         )] public float timeBetweenLums;
		[Serialize("timeAppearNewPet"        )] public float timeAppearNewPet;
		[Serialize("animPlayerDance"         )] public StringID animPlayerDance;
		[Serialize("petPath"                 )] public Path petPath;
		[Serialize("maxConfetti"             )] public uint maxConfetti;
		[Serialize("prisonersMinDelayShort"  )] public float prisonersMinDelayShort;
		[Serialize("prisonersMaxDelayShort"  )] public float prisonersMaxDelayShort;
		[Serialize("prisonersMinDelayLong"   )] public float prisonersMinDelayLong;
		[Serialize("prisonersMaxDelayLong"   )] public float prisonersMaxDelayLong;
		[Serialize("musicEventPrisonersStart")] public Placeholder musicEventPrisonersStart;
		[Serialize("musicEventLowEnd"        )] public Placeholder musicEventLowEnd;
		[Serialize("musicEventHighEnd"       )] public Placeholder musicEventHighEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(timeBetweenLums));
				SerializeField(s, nameof(timeAppearNewPet));
				SerializeField(s, nameof(animPlayerDance));
				SerializeField(s, nameof(petPath));
				SerializeField(s, nameof(maxConfetti));
				SerializeField(s, nameof(prisonersMinDelayShort));
				SerializeField(s, nameof(prisonersMaxDelayShort));
				SerializeField(s, nameof(prisonersMinDelayLong));
				SerializeField(s, nameof(prisonersMaxDelayLong));
				SerializeField(s, nameof(musicEventPrisonersStart));
				SerializeField(s, nameof(musicEventLowEnd));
				SerializeField(s, nameof(musicEventHighEnd));
			} else {
				SerializeField(s, nameof(timeBetweenLums));
				SerializeField(s, nameof(timeAppearNewPet));
				SerializeField(s, nameof(animPlayerDance));
				SerializeField(s, nameof(petPath));
				SerializeField(s, nameof(maxConfetti));
				SerializeField(s, nameof(prisonersMinDelayShort));
				SerializeField(s, nameof(prisonersMaxDelayShort));
				SerializeField(s, nameof(prisonersMinDelayLong));
				SerializeField(s, nameof(prisonersMaxDelayLong));
			}
		}
		public override uint? ClassCRC => 0x9DA6639F;
	}
}

