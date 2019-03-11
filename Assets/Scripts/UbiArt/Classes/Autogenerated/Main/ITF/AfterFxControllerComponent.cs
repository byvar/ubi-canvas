using UnityEngine;

namespace UbiArt.ITF {
	public partial class AfterFxControllerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE711B80F;
	}
}

