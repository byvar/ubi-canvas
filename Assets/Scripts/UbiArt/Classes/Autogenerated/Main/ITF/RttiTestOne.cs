using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RttiTestOne : BaseRttiTest {
		[Serialize("U32Value")] public uint U32Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(U32Value));
		}
		public override uint? ClassCRC => 0x7C5D8CF1;
	}
}

