using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FluidConfig : BaseObject {
		[Serialize(0, "Elasticity")] public float Elasticity;
		[Serialize(1, "Velocity")] public float Velocity;
		[Serialize(2, "Viscosity")] public float Viscosity;
		[Serialize(3, "TargetHeight")] public float TargetHeight;
		[Serialize(4, "Amplification")] public float Amplification;
		[Serialize(5, "TargetMaxHeight")] public float TargetMaxHeight;
		[Serialize(6, "TargetMinHeight")] public float TargetMinHeight;
		[Serialize(7, "TargetAddHeight")] public float TargetAddHeight;
		[Serialize(8, "UnityWidth")] public float UnityWidth;
		[Serialize(9, "PolylineUnityMult")] public uint PolylineUnityMult;
		[Serialize(10, "EnterMult")] public float EnterMult;
		[Serialize(11, "LeaveMult")] public float LeaveMult;
		[Serialize(12, "MaxDstInfluence")] public float MaxDstInfluence;
		[Serialize(13, "LevelsFront")] public uint LevelsFront;
		[Serialize(14, "LevelsBack")] public uint LevelsBack;
		[Serialize(15, "LevelDelta")] public Vector3 LevelDelta;
		[Serialize(16, "UVDelta")] public Vector2 UVDelta;
		[Serialize(17, "PerpendicularBack")] public uint PerpendicularBack;
		[Serialize(18, "PerpendicularBackZ")] public float PerpendicularBackZ;
		[Serialize(19, "PerpendicularBackScale")] public float PerpendicularBackScale;
		[Serialize(20, "PerpendicularBackPos")] public float PerpendicularBackPos;
		[Serialize(21, "PerpendicularBackPosZ")] public float PerpendicularBackPosZ;
		[Serialize(22, "PerpendicularFront")] public uint PerpendicularFront;
		[Serialize(23, "PerpendicularFrontZ")] public float PerpendicularFrontZ;
		[Serialize(24, "PerpendicularFrontScale")] public float PerpendicularFrontScale;
		[Serialize(25, "PerpendicularFrontPos")] public float PerpendicularFrontPos;
		[Serialize(26, "PerpendicularFrontPosZ")] public float PerpendicularFrontPosZ;
		[Serialize(27, "WeightMultiplier")] public float WeightMultiplier;
		[Serialize(28, "dstInfluenceMultiplier")] public float dstInfluenceMultiplier;
		[Serialize(29, "AbsorptionAtEdgeStart")] public float AbsorptionAtEdgeStart;
		[Serialize(30, "AbsorptionAtEdgeEnd")] public float AbsorptionAtEdgeEnd;
		[Serialize(31, "AbsorptionAtEdge_Length")] public float AbsorptionAtEdge_Length;
		[Serialize(32, "InfluenceLimit")] public float InfluenceLimit;
		[Serialize(33, "SideCount")] public uint SideCount;
		[Serialize(34, "LayerCount")] public uint LayerCount;
		[Serialize(35, "BlendFactor")] public float BlendFactor;
		[Serialize(36, "FxActor")] public Path FxActor;
		[Serialize(37, "Layers")] public Container<FluidFriseLayer> layers;

		public FluidConfig(Reader reader) : base(reader) {
		}
	}
}
