using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicTreeNodeSequence : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBDDE5D01;
	}
}

