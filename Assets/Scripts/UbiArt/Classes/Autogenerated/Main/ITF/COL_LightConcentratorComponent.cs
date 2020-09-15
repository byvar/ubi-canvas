using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightConcentratorComponent : CSerializable {
		[Description("amount of light units required to fill container")]
		public float lightUnits;
		[Description("accumulation rate units/second")]
		public float accumulationRate;
		[Description("loss rate, units/second")]
		public float lossRate;
		[Description("SuccessEvent")]
		public Placeholder _event;
		[Description("loss rate, units/second")]
		public Path fxPath;
		[Description("loss rate, units/second")]
		public StringID fxFull;
		[Description("loss rate, units/second")]
		public StringID fxReset;
		[Description("loss rate, units/second")]
		public StringID fxRampup;
		[Description("loss rate, units/second")]
		public float minFxScale;
		[Description("loss rate, units/second")]
		public float maxFxScale;
		[Description("spawned fx offset")]
		public Vec2d fxOffset;
		[Description("spawned fx bone name")]
		public StringID fxBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lightUnits = s.Serialize<float>(lightUnits, name: "lightUnits");
			accumulationRate = s.Serialize<float>(accumulationRate, name: "accumulationRate");
			lossRate = s.Serialize<float>(lossRate, name: "lossRate");
			_event = s.SerializeObject<Placeholder>(_event, name: "_event");
			fxPath = s.SerializeObject<Path>(fxPath, name: "fxPath");
			fxFull = s.SerializeObject<StringID>(fxFull, name: "fxFull");
			fxReset = s.SerializeObject<StringID>(fxReset, name: "fxReset");
			fxRampup = s.SerializeObject<StringID>(fxRampup, name: "fxRampup");
			minFxScale = s.Serialize<float>(minFxScale, name: "minFxScale");
			maxFxScale = s.Serialize<float>(maxFxScale, name: "maxFxScale");
			fxOffset = s.SerializeObject<Vec2d>(fxOffset, name: "fxOffset");
			fxBoneName = s.SerializeObject<StringID>(fxBoneName, name: "fxBoneName");
		}
		public override uint? ClassCRC => 0x8A4975A0;
	}
}

