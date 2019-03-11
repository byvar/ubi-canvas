using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionMusicScore_Template : BTAction_Template {
		[Serialize("appear3dOffset")] public Vector3 appear3dOffset;
		[Serialize("animJump"      )] public StringID animJump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(appear3dOffset));
			SerializeField(s, nameof(animJump));
		}
		public override uint? ClassCRC => 0x0E3FA395;
	}
}

