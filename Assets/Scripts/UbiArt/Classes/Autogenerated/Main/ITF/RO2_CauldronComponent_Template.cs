using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CauldronComponent_Template : ActorComponent_Template {
		[Serialize("standAnim"       )] public StringID standAnim;
		[Serialize("lidReceptionAnim")] public StringID lidReceptionAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(lidReceptionAnim));
		}
		public override uint? ClassCRC => 0x6FBFFBC7;
	}
}

