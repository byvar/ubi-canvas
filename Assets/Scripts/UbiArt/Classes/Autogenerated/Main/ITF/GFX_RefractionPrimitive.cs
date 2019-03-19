using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_RefractionPrimitive : CSerializable {
		[Serialize("PrimitiveParam"  )] public GFXPrimitiveParam PrimitiveParam;
		[Serialize("Intensity"       )] public float Intensity;
		[Serialize("ShowRefracBuffer")] public bool ShowRefracBuffer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(PrimitiveParam));
				SerializeField(s, nameof(Intensity));
				SerializeField(s, nameof(ShowRefracBuffer));
			}
		}
		public override uint? ClassCRC => 0x9F2C5076;
	}
}

