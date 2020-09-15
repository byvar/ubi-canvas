using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightConcentratorComponent : CSerializable {
		[Description("amount of light units required to fill container")]
		[Serialize("lightUnits"      )] public float lightUnits;
		[Description("accumulation rate units/second")]
		[Serialize("accumulationRate")] public float accumulationRate;
		[Description("loss rate, units/second")]
		[Serialize("lossRate"        )] public float lossRate;
		[Description("SuccessEvent")]
		[Serialize("event"           )] public Placeholder _event;
		[Description("loss rate, units/second")]
		[Serialize("fxPath"          )] public Path fxPath;
		[Description("loss rate, units/second")]
		[Serialize("fxFull"          )] public StringID fxFull;
		[Description("loss rate, units/second")]
		[Serialize("fxReset"         )] public StringID fxReset;
		[Description("loss rate, units/second")]
		[Serialize("fxRampup"        )] public StringID fxRampup;
		[Description("loss rate, units/second")]
		[Serialize("minFxScale"      )] public float minFxScale;
		[Description("loss rate, units/second")]
		[Serialize("maxFxScale"      )] public float maxFxScale;
		[Description("spawned fx offset")]
		[Serialize("fxOffset"        )] public Vec2d fxOffset;
		[Description("spawned fx bone name")]
		[Serialize("fxBoneName"      )] public StringID fxBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lightUnits));
			SerializeField(s, nameof(accumulationRate));
			SerializeField(s, nameof(lossRate));
			SerializeField(s, nameof(_event));
			SerializeField(s, nameof(fxPath));
			SerializeField(s, nameof(fxFull));
			SerializeField(s, nameof(fxReset));
			SerializeField(s, nameof(fxRampup));
			SerializeField(s, nameof(minFxScale));
			SerializeField(s, nameof(maxFxScale));
			SerializeField(s, nameof(fxOffset));
			SerializeField(s, nameof(fxBoneName));
		}
		public override uint? ClassCRC => 0x8A4975A0;
	}
}

