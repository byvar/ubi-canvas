using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_124_sub_733750 : CSerializable {
		[Serialize("activeAlpha"  )] public float activeAlpha;
		[Serialize("inactiveAlpha")] public float inactiveAlpha;
		[Serialize("inactiveColor")] public Color inactiveColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activeAlpha));
			SerializeField(s, nameof(inactiveAlpha));
			SerializeField(s, nameof(inactiveColor));
		}
		public override uint? ClassCRC => 0x899DFBCB;
	}
}

