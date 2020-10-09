using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class LightComponent_Template : ActorComponent_Template {
		public float near;
		public float far;
		public string shape;
		public AABB box;
		public float boxRange;
		public Color lightColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			near = s.Serialize<float>(near, name: "near");
			far = s.Serialize<float>(far, name: "far");
			shape = s.Serialize<string>(shape, name: "shape");
			box = s.SerializeObject<AABB>(box, name: "box");
			boxRange = s.Serialize<float>(boxRange, name: "boxRange");
			lightColor = s.SerializeObject<Color>(lightColor, name: "lightColor");
		}
		public override uint? ClassCRC => 0x3A1DD43F;
	}
}

