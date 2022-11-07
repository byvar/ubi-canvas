namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_121_sub_6C4A90 : ActorComponent {
		public int DrawBezier;
		public int DrawSpeedModulation;
		public float ModulateSpeedCoef;
		public float StartMaxSpeed;
		public float StartMinSpeed;
		public float StartingBackTan;
		public float StartingFrontTan;
		public float RollCoeff;
		public int ModuleNumber;
		public float ScaleBase;
		public float ScaleDisplacement;
		public float ScaleOffset;
		public float LoopNumber;
		public Color waitColor;
		public Color foreGroundColor;
		public float foreGroundColorZThreshold;
		public float foreGroundColorZMax;
		public int damagesEnabled;
		public uint animPhaseStart;
		public int deathWanted;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				DrawBezier = s.Serialize<int>(DrawBezier, name: "DrawBezier");
				DrawSpeedModulation = s.Serialize<int>(DrawSpeedModulation, name: "DrawSpeedModulation");
				ModulateSpeedCoef = s.Serialize<float>(ModulateSpeedCoef, name: "ModulateSpeedCoef");
				StartMaxSpeed = s.Serialize<float>(StartMaxSpeed, name: "StartMaxSpeed");
				StartMinSpeed = s.Serialize<float>(StartMinSpeed, name: "StartMinSpeed");
				StartingBackTan = s.Serialize<float>(StartingBackTan, name: "StartingBackTan");
				StartingFrontTan = s.Serialize<float>(StartingFrontTan, name: "StartingFrontTan");
				RollCoeff = s.Serialize<float>(RollCoeff, name: "RollCoeff");
				ModuleNumber = s.Serialize<int>(ModuleNumber, name: "ModuleNumber");
				ScaleBase = s.Serialize<float>(ScaleBase, name: "ScaleBase");
				ScaleDisplacement = s.Serialize<float>(ScaleDisplacement, name: "ScaleDisplacement");
				ScaleOffset = s.Serialize<float>(ScaleOffset, name: "ScaleOffset");
				LoopNumber = s.Serialize<float>(LoopNumber, name: "LoopNumber");
				waitColor = s.SerializeObject<Color>(waitColor, name: "waitColor");
				foreGroundColor = s.SerializeObject<Color>(foreGroundColor, name: "foreGroundColor");
				foreGroundColorZThreshold = s.Serialize<float>(foreGroundColorZThreshold, name: "foreGroundColorZThreshold");
				foreGroundColorZMax = s.Serialize<float>(foreGroundColorZMax, name: "foreGroundColorZMax");
				damagesEnabled = s.Serialize<int>(damagesEnabled, name: "damagesEnabled");
				animPhaseStart = s.Serialize<uint>(animPhaseStart, name: "animPhaseStart");
				deathWanted = s.Serialize<int>(deathWanted, name: "deathWanted");
			}
		}
		public override uint? ClassCRC => 0x48E37CD0;
	}
}

