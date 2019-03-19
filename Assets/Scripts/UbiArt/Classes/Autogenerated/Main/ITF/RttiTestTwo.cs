using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RttiTestTwo : BaseRttiTest {
		[Serialize("BoolValue")] public bool BoolValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(BoolValue));
		}
		public override uint? ClassCRC => 0x2B7167E4;
	}
}

