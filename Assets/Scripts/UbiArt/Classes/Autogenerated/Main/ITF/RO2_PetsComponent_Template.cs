using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PetsComponent_Template : GraphicComponent_Template {
		[Serialize("CellSpace"         )] public float CellSpace;
		[Serialize("Gravity"           )] public float Gravity;
		[Serialize("MassCoeff"         )] public float MassCoeff;
		[Serialize("RadiusMin"         )] public float RadiusMin;
		[Serialize("RadiusMax"         )] public float RadiusMax;
		[Serialize("SwarmCenterCoeff"  )] public float SwarmCenterCoeff;
		[Serialize("Faction"           )] public uint Faction;
		[Serialize("WaitSoundFX"       )] public StringID WaitSoundFX;
		[Serialize("WaitTrHappySoundFX")] public StringID WaitTrHappySoundFX;
		[Serialize("HappySoundFX"      )] public StringID HappySoundFX;
		[Serialize("DrawGrid"          )] public bool DrawGrid;
		[Serialize("DrawOwnerCells"    )] public bool DrawOwnerCells;
		[Serialize("DrawObstacles"     )] public bool DrawObstacles;
		[Serialize("DrawPlayers"       )] public bool DrawPlayers;
		[Serialize("DrawSwarm"         )] public bool DrawSwarm;
		[Serialize("DrawCircles"       )] public bool DrawCircles;
		[Serialize("DrawSoundInfo"     )] public bool DrawSoundInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CellSpace));
			SerializeField(s, nameof(Gravity));
			SerializeField(s, nameof(MassCoeff));
			SerializeField(s, nameof(RadiusMin));
			SerializeField(s, nameof(RadiusMax));
			SerializeField(s, nameof(SwarmCenterCoeff));
			SerializeField(s, nameof(Faction));
			SerializeField(s, nameof(WaitSoundFX));
			SerializeField(s, nameof(WaitTrHappySoundFX));
			SerializeField(s, nameof(HappySoundFX));
			SerializeField(s, nameof(DrawGrid));
			SerializeField(s, nameof(DrawOwnerCells));
			SerializeField(s, nameof(DrawObstacles));
			SerializeField(s, nameof(DrawPlayers));
			SerializeField(s, nameof(DrawSwarm));
			SerializeField(s, nameof(DrawCircles));
			SerializeField(s, nameof(DrawSoundInfo));
		}
		public override uint? ClassCRC => 0xBD8D6CD4;
	}
}

