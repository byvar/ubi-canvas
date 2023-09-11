namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossBirdComponent_Template : ActorComponent_Template {
		public StringID buboBone;
		public bool isMecha;
		public bool playIntroMusic;
		public bool playIntro;
		public float tailDelay;
		public Path egg;
		public StringID eggBone;
		public uint nbEggs;
		public float firstEggDelay;
		public float eggDelay;
		public Path bird;
		public uint nbBirds;
		public float birdYStart;
		public float birdYLow;
		public float birdXOffset;
		public float birdXSpace;
		public float birdYSpace;
		public uint maxLums;
		public CListO<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				buboBone = s.SerializeObject<StringID>(buboBone, name: "buboBone");
				isMecha = s.Serialize<bool>(isMecha, name: "isMecha");
				playIntroMusic = s.Serialize<bool>(playIntroMusic, name: "playIntroMusic");
				playIntro = s.Serialize<bool>(playIntro, name: "playIntro");
				tailDelay = s.Serialize<float>(tailDelay, name: "tailDelay");
				egg = s.SerializeObject<Path>(egg, name: "egg");
				eggBone = s.SerializeObject<StringID>(eggBone, name: "eggBone");
				nbEggs = s.Serialize<uint>(nbEggs, name: "nbEggs");
				firstEggDelay = s.Serialize<float>(firstEggDelay, name: "firstEggDelay");
				eggDelay = s.Serialize<float>(eggDelay, name: "eggDelay");
				bird = s.SerializeObject<Path>(bird, name: "bird");
				nbBirds = s.Serialize<uint>(nbBirds, name: "nbBirds");
				birdYStart = s.Serialize<float>(birdYStart, name: "birdYStart");
				birdYLow = s.Serialize<float>(birdYLow, name: "birdYLow");
				birdXOffset = s.Serialize<float>(birdXOffset, name: "birdXOffset");
				birdXSpace = s.Serialize<float>(birdXSpace, name: "birdXSpace");
				birdYSpace = s.Serialize<float>(birdYSpace, name: "birdYSpace");
				maxLums = s.Serialize<uint>(maxLums, name: "maxLums");
				musics = s.SerializeObject<CListO<EventPlayMusic>>(musics, name: "musics");
			} else {
				buboBone = s.SerializeObject<StringID>(buboBone, name: "buboBone");
				isMecha = s.Serialize<bool>(isMecha, name: "isMecha");
				playIntroMusic = s.Serialize<bool>(playIntroMusic, name: "playIntroMusic");
				playIntro = s.Serialize<bool>(playIntro, name: "playIntro");
				tailDelay = s.Serialize<float>(tailDelay, name: "tailDelay");
				egg = s.SerializeObject<Path>(egg, name: "egg");
				eggBone = s.SerializeObject<StringID>(eggBone, name: "eggBone");
				nbEggs = s.Serialize<uint>(nbEggs, name: "nbEggs");
				firstEggDelay = s.Serialize<float>(firstEggDelay, name: "firstEggDelay");
				eggDelay = s.Serialize<float>(eggDelay, name: "eggDelay");
				bird = s.SerializeObject<Path>(bird, name: "bird");
				nbBirds = s.Serialize<uint>(nbBirds, name: "nbBirds");
				birdYStart = s.Serialize<float>(birdYStart, name: "birdYStart");
				birdYLow = s.Serialize<float>(birdYLow, name: "birdYLow");
				birdXOffset = s.Serialize<float>(birdXOffset, name: "birdXOffset");
				birdXSpace = s.Serialize<float>(birdXSpace, name: "birdXSpace");
				birdYSpace = s.Serialize<float>(birdYSpace, name: "birdYSpace");
				maxLums = s.Serialize<uint>(maxLums, name: "maxLums");
			}
		}
		public override uint? ClassCRC => 0x8971CB0C;
	}
}

