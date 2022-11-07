namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BossBirdAIComponent_Template : Ray_AIComponent_Template {
		public int isMecha;
		public int playIntroMusic;
		public int playIntro;
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
			isMecha = s.Serialize<int>(isMecha, name: "isMecha");
			playIntroMusic = s.Serialize<int>(playIntroMusic, name: "playIntroMusic");
			playIntro = s.Serialize<int>(playIntro, name: "playIntro");
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
		}
		public override uint? ClassCRC => 0x804D1AAC;
	}
}

