using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SeaDragonComponent : ActorComponent {
		[Serialize("DrawBezier"               )] public bool DrawBezier;
		[Serialize("DrawSpeedModulation"      )] public bool DrawSpeedModulation;
		[Serialize("AutoShock"                )] public bool AutoShock;
		[Serialize("AllowFlush"               )] public bool AllowFlush;
		[Serialize("FlushHeight"              )] public float FlushHeight;
		[Serialize("FlushAfterShockDelay"     )] public float FlushAfterShockDelay;
		[Serialize("FlushSpeed"               )] public float FlushSpeed;
		[Serialize("DeathZoneStartOffset"     )] public float DeathZoneStartOffset;
		[Serialize("ModulateSpeedCoef"        )] public float ModulateSpeedCoef;
		[Serialize("StartMaxSpeed"            )] public float StartMaxSpeed;
		[Serialize("StartMinSpeed"            )] public float StartMinSpeed;
		[Serialize("StartingBackTan"          )] public float StartingBackTan;
		[Serialize("StartingFrontTan"         )] public float StartingFrontTan;
		[Serialize("RollCoeff"                )] public float RollCoeff;
		[Serialize("SlowDownDist"             )] public float SlowDownDist;
		[Serialize("IKApproxamationCoeff"     )] public float IKApproxamationCoeff;
		[Serialize("ModuleNumber"             )] public int ModuleNumber;
		[Serialize("ModuleDisplacement"       )] public float ModuleDisplacement;
		[Serialize("HeadBlendRotation"        )] public float HeadBlendRotation;
		[Serialize("ModuleBlendRotation"      )] public float ModuleBlendRotation;
		[Serialize("ScaleBase"                )] public float ScaleBase;
		[Serialize("ScaleDisplacement"        )] public float ScaleDisplacement;
		[Serialize("ScaleOffset"              )] public float ScaleOffset;
		[Serialize("LoopNumber"               )] public float LoopNumber;
		[Serialize("foreGroundColor"          )] public Color foreGroundColor;
		[Serialize("foreGroundColorZThreshold")] public float foreGroundColorZThreshold;
		[Serialize("foreGroundColorZMax"      )] public float foreGroundColorZMax;
		[Serialize("ModuleNumber"             )] public bool ModuleNumber;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(DrawBezier));
					SerializeField(s, nameof(DrawSpeedModulation));
					SerializeField(s, nameof(AutoShock));
					SerializeField(s, nameof(AllowFlush));
					SerializeField(s, nameof(FlushHeight));
					SerializeField(s, nameof(FlushAfterShockDelay));
					SerializeField(s, nameof(FlushSpeed));
					SerializeField(s, nameof(DeathZoneStartOffset));
					SerializeField(s, nameof(ModulateSpeedCoef));
					SerializeField(s, nameof(StartMaxSpeed));
					SerializeField(s, nameof(StartMinSpeed));
					SerializeField(s, nameof(StartingBackTan));
					SerializeField(s, nameof(StartingFrontTan));
					SerializeField(s, nameof(RollCoeff));
					SerializeField(s, nameof(SlowDownDist));
					SerializeField(s, nameof(IKApproxamationCoeff));
					SerializeField(s, nameof(ModuleNumber));
					SerializeField(s, nameof(ModuleDisplacement));
					SerializeField(s, nameof(HeadBlendRotation));
					SerializeField(s, nameof(ModuleBlendRotation));
					SerializeField(s, nameof(ScaleBase));
					SerializeField(s, nameof(ScaleDisplacement));
					SerializeField(s, nameof(ScaleOffset));
					SerializeField(s, nameof(LoopNumber));
					SerializeField(s, nameof(foreGroundColor));
					SerializeField(s, nameof(foreGroundColorZThreshold));
					SerializeField(s, nameof(foreGroundColorZMax));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(DrawBezier));
					SerializeField(s, nameof(DrawSpeedModulation));
					SerializeField(s, nameof(AutoShock));
					SerializeField(s, nameof(AllowFlush));
					SerializeField(s, nameof(FlushHeight));
					SerializeField(s, nameof(FlushAfterShockDelay));
					SerializeField(s, nameof(FlushSpeed));
					SerializeField(s, nameof(DeathZoneStartOffset));
					SerializeField(s, nameof(ModulateSpeedCoef));
					SerializeField(s, nameof(StartMaxSpeed));
					SerializeField(s, nameof(StartMinSpeed));
					SerializeField(s, nameof(StartingBackTan));
					SerializeField(s, nameof(StartingFrontTan));
					SerializeField(s, nameof(RollCoeff));
					SerializeField(s, nameof(SlowDownDist));
					SerializeField(s, nameof(IKApproxamationCoeff));
					SerializeField(s, nameof(ModuleNumber));
					SerializeField(s, nameof(ModuleDisplacement));
					SerializeField(s, nameof(HeadBlendRotation));
					SerializeField(s, nameof(ModuleBlendRotation));
					SerializeField(s, nameof(ScaleBase));
					SerializeField(s, nameof(ScaleDisplacement));
					SerializeField(s, nameof(ScaleOffset));
					SerializeField(s, nameof(LoopNumber));
					SerializeField(s, nameof(foreGroundColor));
					SerializeField(s, nameof(foreGroundColorZThreshold));
					SerializeField(s, nameof(foreGroundColorZMax));
				}
			}
		}
		public override uint? ClassCRC => 0x8EC5ED3A;
	}
}

