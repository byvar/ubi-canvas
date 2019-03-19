using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class FluidConfig : CSerializable {
		[Serialize("Elasticity"             )] public float Elasticity;
		[Serialize("Velocity"               )] public float Velocity;
		[Serialize("Viscosity"              )] public float Viscosity;
		[Serialize("TargetHeight"           )] public float TargetHeight;
		[Serialize("Amplification"          )] public float Amplification;
		[Serialize("TargetMaxHeight"        )] public float TargetMaxHeight;
		[Serialize("TargetMinHeight"        )] public float TargetMinHeight;
		[Serialize("TargetAddHeight"        )] public float TargetAddHeight;
		[Serialize("UnityWidth"             )] public float UnityWidth;
		[Serialize("PolylineUnityMult"      )] public uint PolylineUnityMult;
		[Serialize("PolylineReaction"       )] public bool PolylineReaction;
		[Serialize("EnterMult"              )] public float EnterMult;
		[Serialize("LeaveMult"              )] public float LeaveMult;
		[Serialize("MaxDstInfluence"        )] public float MaxDstInfluence;
		[Serialize("LevelsFront"            )] public uint LevelsFront;
		[Serialize("LevelsBack"             )] public uint LevelsBack;
		[Serialize("LevelDelta"             )] public Vector3 LevelDelta;
		[Serialize("UVDelta"                )] public Vector2 UVDelta;
		[Serialize("PerpendicularBack"      )] public uint PerpendicularBack;
		[Serialize("PerpendicularBackZ"     )] public float PerpendicularBackZ;
		[Serialize("PerpendicularBackScale" )] public float PerpendicularBackScale;
		[Serialize("PerpendicularBackPos"   )] public float PerpendicularBackPos;
		[Serialize("PerpendicularBackPosZ"  )] public float PerpendicularBackPosZ;
		[Serialize("PerpendicularFront"     )] public uint PerpendicularFront;
		[Serialize("PerpendicularFrontZ"    )] public float PerpendicularFrontZ;
		[Serialize("PerpendicularFrontScale")] public float PerpendicularFrontScale;
		[Serialize("PerpendicularFrontPos"  )] public float PerpendicularFrontPos;
		[Serialize("PerpendicularFrontPosZ" )] public float PerpendicularFrontPosZ;
		[Serialize("WeightMultiplier"       )] public float WeightMultiplier;
		[Serialize("dstInfluenceMultiplier" )] public float dstInfluenceMultiplier;
		[Serialize("AbsorptionAtEdgeStart"  )] public float AbsorptionAtEdgeStart;
		[Serialize("AbsorptionAtEdgeEnd"    )] public float AbsorptionAtEdgeEnd;
		[Serialize("AbsorptionAtEdge_Length")] public float AbsorptionAtEdge_Length;
		[Serialize("InfluenceLimit"         )] public float InfluenceLimit;
		[Serialize("SideCount"              )] public uint SideCount;
		[Serialize("LayerCount"             )] public uint LayerCount;
		[Serialize("BlendFactor"            )] public float BlendFactor;
		[Serialize("FxActor"                )] public Path FxActor;
		[Serialize("Layers"                 )] public CList<FluidFriseLayer> Layers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Elasticity));
			SerializeField(s, nameof(Velocity));
			SerializeField(s, nameof(Viscosity));
			SerializeField(s, nameof(TargetHeight));
			SerializeField(s, nameof(Amplification));
			SerializeField(s, nameof(TargetMaxHeight));
			SerializeField(s, nameof(TargetMinHeight));
			SerializeField(s, nameof(TargetAddHeight));
			SerializeField(s, nameof(UnityWidth));
			SerializeField(s, nameof(PolylineUnityMult));
			SerializeField(s, nameof(PolylineReaction));
			SerializeField(s, nameof(EnterMult));
			SerializeField(s, nameof(LeaveMult));
			SerializeField(s, nameof(MaxDstInfluence));
			SerializeField(s, nameof(LevelsFront));
			SerializeField(s, nameof(LevelsBack));
			SerializeField(s, nameof(LevelDelta));
			SerializeField(s, nameof(UVDelta));
			SerializeField(s, nameof(PerpendicularBack));
			SerializeField(s, nameof(PerpendicularBackZ));
			SerializeField(s, nameof(PerpendicularBackScale));
			SerializeField(s, nameof(PerpendicularBackPos));
			SerializeField(s, nameof(PerpendicularBackPosZ));
			SerializeField(s, nameof(PerpendicularFront));
			SerializeField(s, nameof(PerpendicularFrontZ));
			SerializeField(s, nameof(PerpendicularFrontScale));
			SerializeField(s, nameof(PerpendicularFrontPos));
			SerializeField(s, nameof(PerpendicularFrontPosZ));
			SerializeField(s, nameof(WeightMultiplier));
			SerializeField(s, nameof(dstInfluenceMultiplier));
			SerializeField(s, nameof(AbsorptionAtEdgeStart));
			SerializeField(s, nameof(AbsorptionAtEdgeEnd));
			SerializeField(s, nameof(AbsorptionAtEdge_Length));
			SerializeField(s, nameof(InfluenceLimit));
			SerializeField(s, nameof(SideCount));
			SerializeField(s, nameof(LayerCount));
			SerializeField(s, nameof(BlendFactor));
			SerializeField(s, nameof(FxActor));
			SerializeField(s, nameof(Layers));
		}
	}
}

