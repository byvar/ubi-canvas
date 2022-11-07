namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Incubator_Template : TemplateObj {
		public Path IncubatorScenePath;
		public float PopupCooldown;
		public float PopupDuration;
		public float DraggingEggScaleMax;
		public Spline splineHatchingSkipPrice;
		public Spline splineHatchingCommon;
		public Spline splineHatchingUnCommon;
		public Spline splineHatchingRare;
		public Spline splineHatchingQueen;
		public Spline splineHatchingDecoyCommon;
		public Spline splineHatchingDecoyUnCommon;
		public Spline splineHatchingDecoyRare;
		public bool NeedInternetConnectionToHatch;
		public float OnboardingHatchingTimeAdventureEgg1;
		public float OnboardingHatchingTimeAdventureEgg2;
		public float OnboardingHatchingTimeAdventureEgg3;
		public uint nbElixirUncoForceNew;
		public uint nbElixirRareForceNew;
		public Enum_ElixirSpeedHatchingMode ElixirSpeedHatchingMode;
		public float ElixirSpeedHatchingValue;
		public bool AllowElixirAfterHatchingCompleted;
		public Color TimeSaverColorFactor;
		public Color TimeSaverDeluxeColorFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			IncubatorScenePath = s.SerializeObject<Path>(IncubatorScenePath, name: "IncubatorScenePath");
			PopupCooldown = s.Serialize<float>(PopupCooldown, name: "PopupCooldown");
			PopupDuration = s.Serialize<float>(PopupDuration, name: "PopupDuration");
			DraggingEggScaleMax = s.Serialize<float>(DraggingEggScaleMax, name: "DraggingEggScaleMax");
			splineHatchingSkipPrice = s.SerializeObject<Spline>(splineHatchingSkipPrice, name: "splineHatchingSkipPrice");
			splineHatchingCommon = s.SerializeObject<Spline>(splineHatchingCommon, name: "splineHatchingCommon");
			splineHatchingUnCommon = s.SerializeObject<Spline>(splineHatchingUnCommon, name: "splineHatchingUnCommon");
			splineHatchingRare = s.SerializeObject<Spline>(splineHatchingRare, name: "splineHatchingRare");
			splineHatchingQueen = s.SerializeObject<Spline>(splineHatchingQueen, name: "splineHatchingQueen");
			splineHatchingDecoyCommon = s.SerializeObject<Spline>(splineHatchingDecoyCommon, name: "splineHatchingDecoyCommon");
			splineHatchingDecoyUnCommon = s.SerializeObject<Spline>(splineHatchingDecoyUnCommon, name: "splineHatchingDecoyUnCommon");
			splineHatchingDecoyRare = s.SerializeObject<Spline>(splineHatchingDecoyRare, name: "splineHatchingDecoyRare");
			NeedInternetConnectionToHatch = s.Serialize<bool>(NeedInternetConnectionToHatch, name: "NeedInternetConnectionToHatch");
			OnboardingHatchingTimeAdventureEgg1 = s.Serialize<float>(OnboardingHatchingTimeAdventureEgg1, name: "OnboardingHatchingTimeAdventureEgg1");
			OnboardingHatchingTimeAdventureEgg2 = s.Serialize<float>(OnboardingHatchingTimeAdventureEgg2, name: "OnboardingHatchingTimeAdventureEgg2");
			OnboardingHatchingTimeAdventureEgg3 = s.Serialize<float>(OnboardingHatchingTimeAdventureEgg3, name: "OnboardingHatchingTimeAdventureEgg3");
			nbElixirUncoForceNew = s.Serialize<uint>(nbElixirUncoForceNew, name: "nbElixirUncoForceNew");
			nbElixirRareForceNew = s.Serialize<uint>(nbElixirRareForceNew, name: "nbElixirRareForceNew");
			ElixirSpeedHatchingMode = s.Serialize<Enum_ElixirSpeedHatchingMode>(ElixirSpeedHatchingMode, name: "ElixirSpeedHatchingMode");
			ElixirSpeedHatchingValue = s.Serialize<float>(ElixirSpeedHatchingValue, name: "ElixirSpeedHatchingValue");
			AllowElixirAfterHatchingCompleted = s.Serialize<bool>(AllowElixirAfterHatchingCompleted, name: "AllowElixirAfterHatchingCompleted");
			TimeSaverColorFactor = s.SerializeObject<Color>(TimeSaverColorFactor, name: "TimeSaverColorFactor");
			TimeSaverDeluxeColorFactor = s.SerializeObject<Color>(TimeSaverDeluxeColorFactor, name: "TimeSaverDeluxeColorFactor");
		}
		public enum Enum_ElixirSpeedHatchingMode {
			[Serialize("Multiply" )] Multiply = 0,
			[Serialize("Substract")] Substract = 1,
		}
		public override uint? ClassCRC => 0x82501EB2;
	}
}

