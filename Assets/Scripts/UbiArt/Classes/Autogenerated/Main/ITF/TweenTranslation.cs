using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenTranslation : TweenInstruction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7B3BA3C4;
	}
}

