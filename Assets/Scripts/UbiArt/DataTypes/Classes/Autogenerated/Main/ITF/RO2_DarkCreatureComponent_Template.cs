namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DarkCreatureComponent_Template : ActorComponent_Template {
		public float CellSpace;
		public float Gravity;
		public float MassCoeff;
		public float RadiusMin;
		public float RadiusMax;
		public float SwarmCenterCoeff;
		public Vec2d MaxSpeedInLight;
		public uint Faction;
		public bool SkipPlayerInLight;
		public float SkipPlayerInLightTimer;
		public StringID RoamingSoundFX;
		public StringID SpottingSoundFX;
		public StringID ChasingSoundFX;
		public StringID ScaredSoundFX;
		public StringID Pickup;
		public StringID PickupRelease;
		public StringID DieSoundFX;
		public StringID SpotSoundFX;
		public StringID AttackSoundFX;
		public StringID BurnSoundFX;
		public bool DrawGrid;
		public bool DrawOwnerCells;
		public bool DrawObstacles;
		public bool DrawLights;
		public bool DrawPlayers;
		public bool DrawSwarm;
		public bool DrawForces;
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
			MaxSpeedInLight = s.SerializeObject<Vec2d>(MaxSpeedInLight, name: "MaxSpeedInLight");
			Faction = s.Serialize<uint>(Faction, name: "Faction");
			SkipPlayerInLight = s.Serialize<bool>(SkipPlayerInLight, name: "SkipPlayerInLight");
			SkipPlayerInLightTimer = s.Serialize<float>(SkipPlayerInLightTimer, name: "SkipPlayerInLightTimer");
			RoamingSoundFX = s.SerializeObject<StringID>(RoamingSoundFX, name: "RoamingSoundFX");
			SpottingSoundFX = s.SerializeObject<StringID>(SpottingSoundFX, name: "SpottingSoundFX");
			ChasingSoundFX = s.SerializeObject<StringID>(ChasingSoundFX, name: "ChasingSoundFX");
			ScaredSoundFX = s.SerializeObject<StringID>(ScaredSoundFX, name: "ScaredSoundFX");
			Pickup = s.SerializeObject<StringID>(Pickup, name: "Pickup");
			PickupRelease = s.SerializeObject<StringID>(PickupRelease, name: "PickupRelease");
			DieSoundFX = s.SerializeObject<StringID>(DieSoundFX, name: "DieSoundFX");
			SpotSoundFX = s.SerializeObject<StringID>(SpotSoundFX, name: "SpotSoundFX");
			AttackSoundFX = s.SerializeObject<StringID>(AttackSoundFX, name: "AttackSoundFX");
			BurnSoundFX = s.SerializeObject<StringID>(BurnSoundFX, name: "BurnSoundFX");
			DrawGrid = s.Serialize<bool>(DrawGrid, name: "DrawGrid");
			DrawOwnerCells = s.Serialize<bool>(DrawOwnerCells, name: "DrawOwnerCells");
			DrawObstacles = s.Serialize<bool>(DrawObstacles, name: "DrawObstacles");
			DrawLights = s.Serialize<bool>(DrawLights, name: "DrawLights");
			DrawPlayers = s.Serialize<bool>(DrawPlayers, name: "DrawPlayers");
			DrawSwarm = s.Serialize<bool>(DrawSwarm, name: "DrawSwarm");
			DrawForces = s.Serialize<bool>(DrawForces, name: "DrawForces");
			DrawCircles = s.Serialize<bool>(DrawCircles, name: "DrawCircles");
			DrawSoundInfo = s.Serialize<bool>(DrawSoundInfo, name: "DrawSoundInfo");
		}
		public override uint? ClassCRC => 0xE3507F78;
	}
}

