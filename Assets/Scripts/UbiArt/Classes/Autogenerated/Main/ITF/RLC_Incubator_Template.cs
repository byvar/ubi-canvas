using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Incubator_Template : TemplateObj {
		[Serialize("IncubatorScenePath"                 )] public Path IncubatorScenePath;
		[Serialize("PopupCooldown"                      )] public float PopupCooldown;
		[Serialize("PopupDuration"                      )] public float PopupDuration;
		[Serialize("DraggingEggScaleMax"                )] public float DraggingEggScaleMax;
		[Serialize("splineHatchingSkipPrice"            )] public Spline splineHatchingSkipPrice;
		[Serialize("splineHatchingCommon"               )] public Spline splineHatchingCommon;
		[Serialize("splineHatchingUnCommon"             )] public Spline splineHatchingUnCommon;
		[Serialize("splineHatchingRare"                 )] public Spline splineHatchingRare;
		[Serialize("splineHatchingQueen"                )] public Spline splineHatchingQueen;
		[Serialize("splineHatchingDecoyCommon"          )] public Spline splineHatchingDecoyCommon;
		[Serialize("splineHatchingDecoyUnCommon"        )] public Spline splineHatchingDecoyUnCommon;
		[Serialize("splineHatchingDecoyRare"            )] public Spline splineHatchingDecoyRare;
		[Serialize("NeedInternetConnectionToHatch"      )] public bool NeedInternetConnectionToHatch;
		[Serialize("OnboardingHatchingTimeAdventureEgg1")] public float OnboardingHatchingTimeAdventureEgg1;
		[Serialize("OnboardingHatchingTimeAdventureEgg2")] public float OnboardingHatchingTimeAdventureEgg2;
		[Serialize("OnboardingHatchingTimeAdventureEgg3")] public float OnboardingHatchingTimeAdventureEgg3;
		[Serialize("nbElixirUncoForceNew"               )] public uint nbElixirUncoForceNew;
		[Serialize("nbElixirRareForceNew"               )] public uint nbElixirRareForceNew;
		[Serialize("ElixirSpeedHatchingMode"            )] public Enum_ElixirSpeedHatchingMode ElixirSpeedHatchingMode;
		[Serialize("ElixirSpeedHatchingValue"           )] public float ElixirSpeedHatchingValue;
		[Serialize("AllowElixirAfterHatchingCompleted"  )] public bool AllowElixirAfterHatchingCompleted;
		[Serialize("TimeSaverColorFactor"               )] public Color TimeSaverColorFactor;
		[Serialize("TimeSaverDeluxeColorFactor"         )] public Color TimeSaverDeluxeColorFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(IncubatorScenePath));
			SerializeField(s, nameof(PopupCooldown));
			SerializeField(s, nameof(PopupDuration));
			SerializeField(s, nameof(DraggingEggScaleMax));
			SerializeField(s, nameof(splineHatchingSkipPrice));
			SerializeField(s, nameof(splineHatchingCommon));
			SerializeField(s, nameof(splineHatchingUnCommon));
			SerializeField(s, nameof(splineHatchingRare));
			SerializeField(s, nameof(splineHatchingQueen));
			SerializeField(s, nameof(splineHatchingDecoyCommon));
			SerializeField(s, nameof(splineHatchingDecoyUnCommon));
			SerializeField(s, nameof(splineHatchingDecoyRare));
			SerializeField(s, nameof(NeedInternetConnectionToHatch));
			SerializeField(s, nameof(OnboardingHatchingTimeAdventureEgg1));
			SerializeField(s, nameof(OnboardingHatchingTimeAdventureEgg2));
			SerializeField(s, nameof(OnboardingHatchingTimeAdventureEgg3));
			SerializeField(s, nameof(nbElixirUncoForceNew));
			SerializeField(s, nameof(nbElixirRareForceNew));
			SerializeField(s, nameof(ElixirSpeedHatchingMode));
			SerializeField(s, nameof(ElixirSpeedHatchingValue));
			SerializeField(s, nameof(AllowElixirAfterHatchingCompleted));
			SerializeField(s, nameof(TimeSaverColorFactor));
			SerializeField(s, nameof(TimeSaverDeluxeColorFactor));
		}
		public enum Enum_ElixirSpeedHatchingMode {
			[Serialize("Multiply" )] Multiply = 0,
			[Serialize("Substract")] Substract = 1,
		}
		public override uint? ClassCRC => 0x82501EB2;
	}
}

