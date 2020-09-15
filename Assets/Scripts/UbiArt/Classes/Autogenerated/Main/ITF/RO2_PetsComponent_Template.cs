using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PetsComponent_Template : GraphicComponent_Template {
		public float CellSpace;
		public float Gravity;
		public float MassCoeff;
		public float RadiusMin;
		public float RadiusMax;
		public float SwarmCenterCoeff;
		public uint Faction;
		public StringID WaitSoundFX;
		public StringID WaitTrHappySoundFX;
		public StringID HappySoundFX;
		public bool DrawGrid;
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
			WaitSoundFX = s.SerializeObject<StringID>(WaitSoundFX, name: "WaitSoundFX");
			WaitTrHappySoundFX = s.SerializeObject<StringID>(WaitTrHappySoundFX, name: "WaitTrHappySoundFX");
			HappySoundFX = s.SerializeObject<StringID>(HappySoundFX, name: "HappySoundFX");
			DrawGrid = s.Serialize<bool>(DrawGrid, name: "DrawGrid");
			DrawOwnerCells = s.Serialize<bool>(DrawOwnerCells, name: "DrawOwnerCells");
			DrawObstacles = s.Serialize<bool>(DrawObstacles, name: "DrawObstacles");
			DrawPlayers = s.Serialize<bool>(DrawPlayers, name: "DrawPlayers");
			DrawSwarm = s.Serialize<bool>(DrawSwarm, name: "DrawSwarm");
			DrawCircles = s.Serialize<bool>(DrawCircles, name: "DrawCircles");
			DrawSoundInfo = s.Serialize<bool>(DrawSoundInfo, name: "DrawSoundInfo");
		}
		public override uint? ClassCRC => 0xBD8D6CD4;
	}
}

