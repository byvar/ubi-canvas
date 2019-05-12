using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class LightComponent_Template : ActorComponent_Template {
		[Serialize("near"      )] public float near;
		[Serialize("far"       )] public float far;
		[Serialize("shape"     )] public string shape;
		[Serialize("box"       )] public AABB box;
		[Serialize("boxRange"  )] public float boxRange;
		[Serialize("lightColor")] public Color lightColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(near));
			SerializeField(s, nameof(far));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(box));
			SerializeField(s, nameof(boxRange));
			SerializeField(s, nameof(lightColor));
		}
		public override uint? ClassCRC => 0x3A1DD43F;
	}
}

