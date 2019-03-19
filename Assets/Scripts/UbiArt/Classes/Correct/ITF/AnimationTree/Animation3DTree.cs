using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class Animation3DTree : BlendTree<Animation3DTreeResult> {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2FF4CFD5;
	}
}
