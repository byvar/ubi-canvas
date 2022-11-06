using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RttiTestOne : BaseRttiTest {
		public uint U32Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			U32Value = s.Serialize<uint>(U32Value, name: "U32Value");
		}
		public override uint? ClassCRC => 0x7C5D8CF1;
	}
}

