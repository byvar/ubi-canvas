using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_BlurPrimitive : CSerializable {
		[Serialize("PrimitiveParam")] public GFXPrimitiveParam PrimitiveParam;
		[Serialize("Size"          )] public float Size;
		[Serialize("Alpha"         )] public float Alpha;
		[Serialize("LargeBlur"     )] public bool LargeBlur;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(PrimitiveParam));
				SerializeField(s, nameof(Size));
				SerializeField(s, nameof(Alpha));
				SerializeField(s, nameof(LargeBlur));
			}
		}
		public override uint? ClassCRC => 0xFB5056C1;
	}
}

