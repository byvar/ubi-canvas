namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LumsPoolComponent_Template : ActorComponent_Template {
		public float CellSpace = 1f;
		public float Gravity = 9.81f;
		public float MassCoeff = 1f;
		public float RadiusMin = 1f;
		public float RadiusMax = 1f;
		public float SwarmCenterCoeff = 10f;
		public uint Faction;
		public bool IsBonusPet;
		public StringID AnimWait = new StringID("Yellow_Stand");
		public StringID AnimReact = new StringID("Yellow_Picked");
		public StringID AnimHappy = new StringID("Yellow_Picked_Cycle");
		public StringID AnimAppear;
		public StringID AnimFade;
		public StringID WaitSoundFX;
		public StringID ReactSoundFX;
		public StringID HappySoundFX;
		public bool DrawGrid = true;
		public bool DrawOwnerCells;
		public bool DrawObstacles;
		public bool DrawPlayers;
		public bool DrawSwarm;
		public bool DrawCircles;
		public bool DrawSoundInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CellSpace = s.Serialize<float>(CellSpace, name: "CellSpace");
			Gravity = s.Serialize<float>(Gravity, name: "Gravity");
			MassCoeff = s.Serialize<float>(MassCoeff, name: "MassCoeff");
			RadiusMin = s.Serialize<float>(RadiusMin, name: "RadiusMin");
			RadiusMax = s.Serialize<float>(RadiusMax, name: "RadiusMax");
			SwarmCenterCoeff = s.Serialize<float>(SwarmCenterCoeff, name: "SwarmCenterCoeff");
			Faction = s.Serialize<uint>(Faction, name: "Faction");
			IsBonusPet = s.Serialize<bool>(IsBonusPet, name: "IsBonusPet");
			AnimWait = s.SerializeObject<StringID>(AnimWait, name: "AnimWait");
			AnimReact = s.SerializeObject<StringID>(AnimReact, name: "AnimReact");
			AnimHappy = s.SerializeObject<StringID>(AnimHappy, name: "AnimHappy");
			AnimAppear = s.SerializeObject<StringID>(AnimAppear, name: "AnimAppear");
			AnimFade = s.SerializeObject<StringID>(AnimFade, name: "AnimFade");
			WaitSoundFX = s.SerializeObject<StringID>(WaitSoundFX, name: "WaitSoundFX");
			ReactSoundFX = s.SerializeObject<StringID>(ReactSoundFX, name: "ReactSoundFX");
			HappySoundFX = s.SerializeObject<StringID>(HappySoundFX, name: "HappySoundFX");
			DrawGrid = s.Serialize<bool>(DrawGrid, name: "DrawGrid");
			DrawOwnerCells = s.Serialize<bool>(DrawOwnerCells, name: "DrawOwnerCells");
			DrawObstacles = s.Serialize<bool>(DrawObstacles, name: "DrawObstacles");
			DrawPlayers = s.Serialize<bool>(DrawPlayers, name: "DrawPlayers");
			DrawSwarm = s.Serialize<bool>(DrawSwarm, name: "DrawSwarm");
			DrawCircles = s.Serialize<bool>(DrawCircles, name: "DrawCircles");
			DrawSoundInfo = s.Serialize<bool>(DrawSoundInfo, name: "DrawSoundInfo");
		}
		public override uint? ClassCRC => 0x58768124;
	}
}

