using UnityEngine;

namespace UbiArt.ITF {
	public partial class ShadowZonesComponent : ActorComponent {
		[Serialize("LightPrimitiveParameters"      )] public GFXPrimitiveParam LightPrimitiveParameters;
		[Serialize("LightBackPrimitiveParameters"  )] public GFXPrimitiveParam LightBackPrimitiveParameters;
		[Serialize("ShadowsPrimitiveParameters"    )] public GFXPrimitiveParam ShadowsPrimitiveParameters;
		[Serialize("ShadowsBackPrimitiveParameters")] public GFXPrimitiveParam ShadowsBackPrimitiveParameters;
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
		public override uint? ClassCRC => 0xC2E066BD;
	}
}

