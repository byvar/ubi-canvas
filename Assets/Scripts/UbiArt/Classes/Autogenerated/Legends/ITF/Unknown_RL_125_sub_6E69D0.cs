using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_125_sub_6E69D0 : CSerializable {
		[Serialize("DEBUG_StartOnPattern")] public uint DEBUG_StartOnPattern;
		[Serialize("DEBUG_StartOnPhase"  )] public uint DEBUG_StartOnPhase;
		[Serialize("Alpha"               )] public float Alpha;
		[Serialize("SpawnFlowBySec"      )] public uint SpawnFlowBySec;
		[Serialize("SpawnForceCoeff"     )] public float SpawnForceCoeff;
		[Serialize("SpawnRandom"         )] public Vector3 SpawnRandom;
		[Serialize("IsLooping"           )] public int IsLooping;
		[Serialize("DeactivateRoll"      )] public int DeactivateRoll;
		[Serialize("SinusSpeedX"         )] public float SinusSpeedX;
		[Serialize("SinusSpeedY"         )] public float SinusSpeedY;
		[Serialize("SinusAmplitudeX"     )] public float SinusAmplitudeX;
		[Serialize("SinusAmplitudeY"     )] public float SinusAmplitudeY;
		[Serialize("SinusLoopX"          )] public float SinusLoopX;
		[Serialize("SinusLoopY"          )] public float SinusLoopY;
		[Serialize("ModulateSpeedCoef"   )] public float ModulateSpeedCoef;
		[Serialize("StartSpeed"          )] public float StartSpeed;
		[Serialize("StartingBackTan"     )] public float StartingBackTan;
		[Serialize("StartingFrontTan"    )] public float StartingFrontTan;
		[Serialize("SlowDownDist"        )] public float SlowDownDist;
		[Serialize("Phase3_OrientCoeff"  )] public float Phase3_OrientCoeff;
		[Serialize("Phase3_OrientBlend"  )] public float Phase3_OrientBlend;
		[Serialize("AppearanceDone"      )] public int AppearanceDone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(DEBUG_StartOnPattern));
				SerializeField(s, nameof(DEBUG_StartOnPhase));
				SerializeField(s, nameof(Alpha));
				SerializeField(s, nameof(SpawnFlowBySec));
				SerializeField(s, nameof(SpawnForceCoeff));
				SerializeField(s, nameof(SpawnRandom));
				SerializeField(s, nameof(IsLooping));
				SerializeField(s, nameof(DeactivateRoll));
				SerializeField(s, nameof(SinusSpeedX));
				SerializeField(s, nameof(SinusSpeedY));
				SerializeField(s, nameof(SinusAmplitudeX));
				SerializeField(s, nameof(SinusAmplitudeY));
				SerializeField(s, nameof(SinusLoopX));
				SerializeField(s, nameof(SinusLoopY));
				SerializeField(s, nameof(ModulateSpeedCoef));
				SerializeField(s, nameof(StartSpeed));
				SerializeField(s, nameof(StartingBackTan));
				SerializeField(s, nameof(StartingFrontTan));
				SerializeField(s, nameof(SlowDownDist));
				SerializeField(s, nameof(Phase3_OrientCoeff));
				SerializeField(s, nameof(Phase3_OrientBlend));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(AppearanceDone));
			}
		}
		public override uint? ClassCRC => 0xB49AC34B;
	}
}

