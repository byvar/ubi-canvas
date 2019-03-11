using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionDisappearBackground_Template : BTAction_Template {
		[Serialize("animAnticipBack"  )] public StringID animAnticipBack;
		[Serialize("animJumpBack"     )] public StringID animJumpBack;
		[Serialize("animAnticipFore"  )] public StringID animAnticipFore;
		[Serialize("animJumpFore"     )] public StringID animJumpFore;
		[Serialize("offsetDefaultJump")] public Vector3 offsetDefaultJump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animAnticipBack));
			SerializeField(s, nameof(animJumpBack));
			SerializeField(s, nameof(animAnticipFore));
			SerializeField(s, nameof(animJumpFore));
			SerializeField(s, nameof(offsetDefaultJump));
		}
		public override uint? ClassCRC => 0xEF79604C;
	}
}

