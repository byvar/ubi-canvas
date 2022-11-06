using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_125_sub_6E69D0 : ActorComponent {
		public uint DEBUG_StartOnPattern;
		public uint DEBUG_StartOnPhase;
		public float Alpha;
		public uint SpawnFlowBySec;
		public float SpawnForceCoeff;
		public Vec3d SpawnRandom;
		public int IsLooping;
		public int DeactivateRoll;
		public float SinusSpeedX;
		public float SinusSpeedY;
		public float SinusAmplitudeX;
		public float SinusAmplitudeY;
		public float SinusLoopX;
		public float SinusLoopY;
		public float ModulateSpeedCoef;
		public float StartSpeed;
		public float StartingBackTan;
		public float StartingFrontTan;
		public float SlowDownDist;
		public float Phase3_OrientCoeff;
		public float Phase3_OrientBlend;
		public int AppearanceDone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				DEBUG_StartOnPattern = s.Serialize<uint>(DEBUG_StartOnPattern, name: "DEBUG_StartOnPattern");
				DEBUG_StartOnPhase = s.Serialize<uint>(DEBUG_StartOnPhase, name: "DEBUG_StartOnPhase");
				Alpha = s.Serialize<float>(Alpha, name: "Alpha");
				SpawnFlowBySec = s.Serialize<uint>(SpawnFlowBySec, name: "SpawnFlowBySec");
				SpawnForceCoeff = s.Serialize<float>(SpawnForceCoeff, name: "SpawnForceCoeff");
				SpawnRandom = s.SerializeObject<Vec3d>(SpawnRandom, name: "SpawnRandom");
				IsLooping = s.Serialize<int>(IsLooping, name: "IsLooping");
				DeactivateRoll = s.Serialize<int>(DeactivateRoll, name: "DeactivateRoll");
				SinusSpeedX = s.Serialize<float>(SinusSpeedX, name: "SinusSpeedX");
				SinusSpeedY = s.Serialize<float>(SinusSpeedY, name: "SinusSpeedY");
				SinusAmplitudeX = s.Serialize<float>(SinusAmplitudeX, name: "SinusAmplitudeX");
				SinusAmplitudeY = s.Serialize<float>(SinusAmplitudeY, name: "SinusAmplitudeY");
				SinusLoopX = s.Serialize<float>(SinusLoopX, name: "SinusLoopX");
				SinusLoopY = s.Serialize<float>(SinusLoopY, name: "SinusLoopY");
				ModulateSpeedCoef = s.Serialize<float>(ModulateSpeedCoef, name: "ModulateSpeedCoef");
				StartSpeed = s.Serialize<float>(StartSpeed, name: "StartSpeed");
				StartingBackTan = s.Serialize<float>(StartingBackTan, name: "StartingBackTan");
				StartingFrontTan = s.Serialize<float>(StartingFrontTan, name: "StartingFrontTan");
				SlowDownDist = s.Serialize<float>(SlowDownDist, name: "SlowDownDist");
				Phase3_OrientCoeff = s.Serialize<float>(Phase3_OrientCoeff, name: "Phase3_OrientCoeff");
				Phase3_OrientBlend = s.Serialize<float>(Phase3_OrientBlend, name: "Phase3_OrientBlend");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				AppearanceDone = s.Serialize<int>(AppearanceDone, name: "AppearanceDone");
			}
		}
		public override uint? ClassCRC => 0xB49AC34B;
	}
}

