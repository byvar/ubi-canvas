using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionBumper_Template : BTAction_Template {
		[Serialize("jumpForce")] public float jumpForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpForce));
		}
		public override uint? ClassCRC => 0x54569C51;
	}
}

