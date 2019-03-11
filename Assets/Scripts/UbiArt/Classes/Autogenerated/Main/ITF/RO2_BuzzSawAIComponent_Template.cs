using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BuzzSawAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("openAnim"    )] public StringID openAnim;
		[Serialize("closedAnim"  )] public StringID closedAnim;
		[Serialize("hurtPolyline")] public StringID hurtPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(closedAnim));
			SerializeField(s, nameof(hurtPolyline));
		}
		public override uint? ClassCRC => 0x3D4CE2D4;
	}
}

