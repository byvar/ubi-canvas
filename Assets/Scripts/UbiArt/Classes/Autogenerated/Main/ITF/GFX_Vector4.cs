using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class GFX_Vector4 : CSerializable {
		public float x;
		public float y;
		public float z;
		public float w;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			x = s.Serialize<float>(x, name: "x");
			y = s.Serialize<float>(y, name: "y");
			z = s.Serialize<float>(z, name: "z");
			w = s.Serialize<float>(w, name: "w");
		}
	}
}

