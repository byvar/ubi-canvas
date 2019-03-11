using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CauldronLidComponent_Template : ActorComponent_Template {
		[Serialize("freeFallAnim"       )] public StringID freeFallAnim;
		[Serialize("groundReceptionAnim")] public StringID groundReceptionAnim;
		[Serialize("standAnim"          )] public StringID standAnim;
		[Serialize("snappedAnim"        )] public StringID snappedAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(freeFallAnim));
			SerializeField(s, nameof(groundReceptionAnim));
			SerializeField(s, nameof(standAnim));
			SerializeField(s, nameof(snappedAnim));
		}
		public override uint? ClassCRC => 0x99BB793A;
	}
}

