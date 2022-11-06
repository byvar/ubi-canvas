using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_BlurPrimitive : CSerializable {
		public GFXPrimitiveParam PrimitiveParam;
		public float Size;
		public float Alpha;
		public bool LargeBlur;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				PrimitiveParam = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParam, name: "PrimitiveParam");
				Size = s.Serialize<float>(Size, name: "Size");
				Alpha = s.Serialize<float>(Alpha, name: "Alpha");
				LargeBlur = s.Serialize<bool>(LargeBlur, name: "LargeBlur");
			}
		}
		public override uint? ClassCRC => 0xFB5056C1;
	}
}

