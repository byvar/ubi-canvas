namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SeaDragonComponent : ActorComponent {
		public bool DrawBezier;
		public bool DrawSpeedModulation;
		public bool AutoShock;
		public bool AllowFlush;
		public float FlushHeight;
		public float FlushAfterShockDelay;
		public float FlushSpeed;
		public float DeathZoneStartOffset;
		public float ModulateSpeedCoef;
		public float StartMaxSpeed;
		public float StartMinSpeed;
		public float StartingBackTan;
		public float StartingFrontTan;
		public float RollCoeff;
		public float SlowDownDist;
		public float IKApproxamationCoeff;
		public int ModuleNumber;
		public float ModuleDisplacement;
		public float HeadBlendRotation;
		public float ModuleBlendRotation;
		public float ScaleBase;
		public float ScaleDisplacement;
		public float ScaleOffset;
		public float LoopNumber;
		public Color foreGroundColor;
		public float foreGroundColorZThreshold;
		public float foreGroundColorZMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				DrawBezier = s.Serialize<bool>(DrawBezier, name: "DrawBezier");
				DrawSpeedModulation = s.Serialize<bool>(DrawSpeedModulation, name: "DrawSpeedModulation");
				AutoShock = s.Serialize<bool>(AutoShock, name: "AutoShock");
				AllowFlush = s.Serialize<bool>(AllowFlush, name: "AllowFlush");
				FlushHeight = s.Serialize<float>(FlushHeight, name: "FlushHeight");
				FlushAfterShockDelay = s.Serialize<float>(FlushAfterShockDelay, name: "FlushAfterShockDelay");
				FlushSpeed = s.Serialize<float>(FlushSpeed, name: "FlushSpeed");
				DeathZoneStartOffset = s.Serialize<float>(DeathZoneStartOffset, name: "DeathZoneStartOffset");
				ModulateSpeedCoef = s.Serialize<float>(ModulateSpeedCoef, name: "ModulateSpeedCoef");
				StartMaxSpeed = s.Serialize<float>(StartMaxSpeed, name: "StartMaxSpeed");
				StartMinSpeed = s.Serialize<float>(StartMinSpeed, name: "StartMinSpeed");
				StartingBackTan = s.Serialize<float>(StartingBackTan, name: "StartingBackTan");
				StartingFrontTan = s.Serialize<float>(StartingFrontTan, name: "StartingFrontTan");
				RollCoeff = s.Serialize<float>(RollCoeff, name: "RollCoeff");
				SlowDownDist = s.Serialize<float>(SlowDownDist, name: "SlowDownDist");
				IKApproxamationCoeff = s.Serialize<float>(IKApproxamationCoeff, name: "IKApproxamationCoeff");
				ModuleNumber = s.Serialize<int>(ModuleNumber, name: "ModuleNumber");
				ModuleDisplacement = s.Serialize<float>(ModuleDisplacement, name: "ModuleDisplacement");
				HeadBlendRotation = s.Serialize<float>(HeadBlendRotation, name: "HeadBlendRotation");
				ModuleBlendRotation = s.Serialize<float>(ModuleBlendRotation, name: "ModuleBlendRotation");
				ScaleBase = s.Serialize<float>(ScaleBase, name: "ScaleBase");
				ScaleDisplacement = s.Serialize<float>(ScaleDisplacement, name: "ScaleDisplacement");
				ScaleOffset = s.Serialize<float>(ScaleOffset, name: "ScaleOffset");
				LoopNumber = s.Serialize<float>(LoopNumber, name: "LoopNumber");
				foreGroundColor = s.SerializeObject<Color>(foreGroundColor, name: "foreGroundColor");
				foreGroundColorZThreshold = s.Serialize<float>(foreGroundColorZThreshold, name: "foreGroundColorZThreshold");
				foreGroundColorZMax = s.Serialize<float>(foreGroundColorZMax, name: "foreGroundColorZMax");
			}
		}
		public override uint? ClassCRC => 0x8EC5ED3A;
	}
}

