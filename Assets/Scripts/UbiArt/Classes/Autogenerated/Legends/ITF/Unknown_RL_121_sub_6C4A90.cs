using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_121_sub_6C4A90 : CSerializable {
		[Serialize("DrawBezier"               )] public int DrawBezier;
		[Serialize("DrawSpeedModulation"      )] public int DrawSpeedModulation;
		[Serialize("ModulateSpeedCoef"        )] public float ModulateSpeedCoef;
		[Serialize("StartMaxSpeed"            )] public float StartMaxSpeed;
		[Serialize("StartMinSpeed"            )] public float StartMinSpeed;
		[Serialize("StartingBackTan"          )] public float StartingBackTan;
		[Serialize("StartingFrontTan"         )] public float StartingFrontTan;
		[Serialize("RollCoeff"                )] public float RollCoeff;
		[Serialize("ModuleNumber"             )] public int ModuleNumber;
		[Serialize("ScaleBase"                )] public float ScaleBase;
		[Serialize("ScaleDisplacement"        )] public float ScaleDisplacement;
		[Serialize("ScaleOffset"              )] public float ScaleOffset;
		[Serialize("LoopNumber"               )] public float LoopNumber;
		[Serialize("waitColor"                )] public Color waitColor;
		[Serialize("foreGroundColor"          )] public Color foreGroundColor;
		[Serialize("foreGroundColorZThreshold")] public float foreGroundColorZThreshold;
		[Serialize("foreGroundColorZMax"      )] public float foreGroundColorZMax;
		[Serialize("damagesEnabled"           )] public int damagesEnabled;
		[Serialize("animPhaseStart"           )] public uint animPhaseStart;
		[Serialize("deathWanted"              )] public int deathWanted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(DrawBezier));
				SerializeField(s, nameof(DrawSpeedModulation));
				SerializeField(s, nameof(ModulateSpeedCoef));
				SerializeField(s, nameof(StartMaxSpeed));
				SerializeField(s, nameof(StartMinSpeed));
				SerializeField(s, nameof(StartingBackTan));
				SerializeField(s, nameof(StartingFrontTan));
				SerializeField(s, nameof(RollCoeff));
				SerializeField(s, nameof(ModuleNumber));
				SerializeField(s, nameof(ScaleBase));
				SerializeField(s, nameof(ScaleDisplacement));
				SerializeField(s, nameof(ScaleOffset));
				SerializeField(s, nameof(LoopNumber));
				SerializeField(s, nameof(waitColor));
				SerializeField(s, nameof(foreGroundColor));
				SerializeField(s, nameof(foreGroundColorZThreshold));
				SerializeField(s, nameof(foreGroundColorZMax));
				SerializeField(s, nameof(damagesEnabled));
				SerializeField(s, nameof(animPhaseStart));
				SerializeField(s, nameof(deathWanted));
			}
		}
		public override uint? ClassCRC => 0x48E37CD0;
	}
}

