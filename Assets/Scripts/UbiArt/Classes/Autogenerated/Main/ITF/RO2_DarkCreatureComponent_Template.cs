using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DarkCreatureComponent_Template : ActorComponent_Template {
		[Serialize("CellSpace"             )] public float CellSpace;
		[Serialize("Gravity"               )] public float Gravity;
		[Serialize("MassCoeff"             )] public float MassCoeff;
		[Serialize("RadiusMin"             )] public float RadiusMin;
		[Serialize("RadiusMax"             )] public float RadiusMax;
		[Serialize("SwarmCenterCoeff"      )] public float SwarmCenterCoeff;
		[Serialize("MaxSpeedInLight"       )] public Vector2 MaxSpeedInLight;
		[Serialize("Faction"               )] public uint Faction;
		[Serialize("SkipPlayerInLight"     )] public bool SkipPlayerInLight;
		[Serialize("SkipPlayerInLightTimer")] public float SkipPlayerInLightTimer;
		[Serialize("RoamingSoundFX"        )] public StringID RoamingSoundFX;
		[Serialize("SpottingSoundFX"       )] public StringID SpottingSoundFX;
		[Serialize("ChasingSoundFX"        )] public StringID ChasingSoundFX;
		[Serialize("ScaredSoundFX"         )] public StringID ScaredSoundFX;
		[Serialize("Pickup"                )] public StringID Pickup;
		[Serialize("PickupRelease"         )] public StringID PickupRelease;
		[Serialize("DieSoundFX"            )] public StringID DieSoundFX;
		[Serialize("SpotSoundFX"           )] public StringID SpotSoundFX;
		[Serialize("AttackSoundFX"         )] public StringID AttackSoundFX;
		[Serialize("BurnSoundFX"           )] public StringID BurnSoundFX;
		[Serialize("DrawGrid"              )] public bool DrawGrid;
		[Serialize("DrawOwnerCells"        )] public bool DrawOwnerCells;
		[Serialize("DrawObstacles"         )] public bool DrawObstacles;
		[Serialize("DrawLights"            )] public bool DrawLights;
		[Serialize("DrawPlayers"           )] public bool DrawPlayers;
		[Serialize("DrawSwarm"             )] public bool DrawSwarm;
		[Serialize("DrawForces"            )] public bool DrawForces;
		[Serialize("DrawCircles"           )] public bool DrawCircles;
		[Serialize("DrawSoundInfo"         )] public bool DrawSoundInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CellSpace));
			SerializeField(s, nameof(Gravity));
			SerializeField(s, nameof(MassCoeff));
			SerializeField(s, nameof(RadiusMin));
			SerializeField(s, nameof(RadiusMax));
			SerializeField(s, nameof(SwarmCenterCoeff));
			SerializeField(s, nameof(MaxSpeedInLight));
			SerializeField(s, nameof(Faction));
			SerializeField(s, nameof(SkipPlayerInLight));
			SerializeField(s, nameof(SkipPlayerInLightTimer));
			SerializeField(s, nameof(RoamingSoundFX));
			SerializeField(s, nameof(SpottingSoundFX));
			SerializeField(s, nameof(ChasingSoundFX));
			SerializeField(s, nameof(ScaredSoundFX));
			SerializeField(s, nameof(Pickup));
			SerializeField(s, nameof(PickupRelease));
			SerializeField(s, nameof(DieSoundFX));
			SerializeField(s, nameof(SpotSoundFX));
			SerializeField(s, nameof(AttackSoundFX));
			SerializeField(s, nameof(BurnSoundFX));
			SerializeField(s, nameof(DrawGrid));
			SerializeField(s, nameof(DrawOwnerCells));
			SerializeField(s, nameof(DrawObstacles));
			SerializeField(s, nameof(DrawLights));
			SerializeField(s, nameof(DrawPlayers));
			SerializeField(s, nameof(DrawSwarm));
			SerializeField(s, nameof(DrawForces));
			SerializeField(s, nameof(DrawCircles));
			SerializeField(s, nameof(DrawSoundInfo));
		}
		public override uint? ClassCRC => 0xE3507F78;
	}
}

