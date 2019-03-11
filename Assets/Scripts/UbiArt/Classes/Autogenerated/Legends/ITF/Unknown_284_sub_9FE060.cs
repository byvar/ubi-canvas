using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_284_sub_9FE060 : CSerializable {
		[Serialize("LightPrimitiveParameters"      )] public Placeholder LightPrimitiveParameters;
		[Serialize("LightBackPrimitiveParameters"  )] public Placeholder LightBackPrimitiveParameters;
		[Serialize("ShadowsPrimitiveParameters"    )] public Placeholder ShadowsPrimitiveParameters;
		[Serialize("ShadowsBackPrimitiveParameters")] public Placeholder ShadowsBackPrimitiveParameters;
		[Serialize("radius"                        )] public float radius;
		[Serialize("angle"                         )] public Angle angle;
		[Serialize("angleOffset"                   )] public Angle angleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(LightPrimitiveParameters));
			SerializeField(s, nameof(LightBackPrimitiveParameters));
			SerializeField(s, nameof(ShadowsPrimitiveParameters));
			SerializeField(s, nameof(ShadowsBackPrimitiveParameters));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(angleOffset));
		}
		public override uint? ClassCRC => 0xAA4BCE24;
	}
}

