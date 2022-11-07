namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GlobalTeensieCounterComponent_Template : ActorComponent_Template {
		public LocalisationId locID;
		public StringID standAnim;
		public float travelDuration;
		public float fastTravelDuration;
		public float scale;
		public float apexScale;
		public float finaleScale;
		public float intervalTime;
		public StringID startFX;
		public StringID endFX;
		public float transitionDuration;
		public uint nbRebound;
		public Vec2d startOffset;
		public float displayDuration;
		public float pulseScaleMultiplier;
		public float pulseIncreaseTime;
		public float pulseSustainTime;
		public float pulseDecreaseTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locID = s.SerializeObject<LocalisationId>(locID, name: "locID");
			standAnim = s.SerializeObject<StringID>(standAnim, name: "standAnim");
			travelDuration = s.Serialize<float>(travelDuration, name: "travelDuration");
			fastTravelDuration = s.Serialize<float>(fastTravelDuration, name: "fastTravelDuration");
			scale = s.Serialize<float>(scale, name: "scale");
			apexScale = s.Serialize<float>(apexScale, name: "apexScale");
			finaleScale = s.Serialize<float>(finaleScale, name: "finaleScale");
			intervalTime = s.Serialize<float>(intervalTime, name: "intervalTime");
			startFX = s.SerializeObject<StringID>(startFX, name: "startFX");
			endFX = s.SerializeObject<StringID>(endFX, name: "endFX");
			transitionDuration = s.Serialize<float>(transitionDuration, name: "transitionDuration");
			nbRebound = s.Serialize<uint>(nbRebound, name: "nbRebound");
			startOffset = s.SerializeObject<Vec2d>(startOffset, name: "startOffset");
			displayDuration = s.Serialize<float>(displayDuration, name: "displayDuration");
			pulseScaleMultiplier = s.Serialize<float>(pulseScaleMultiplier, name: "pulseScaleMultiplier");
			pulseIncreaseTime = s.Serialize<float>(pulseIncreaseTime, name: "pulseIncreaseTime");
			pulseSustainTime = s.Serialize<float>(pulseSustainTime, name: "pulseSustainTime");
			pulseDecreaseTime = s.Serialize<float>(pulseDecreaseTime, name: "pulseDecreaseTime");
		}
		public override uint? ClassCRC => 0x741A5D27;
	}
}

