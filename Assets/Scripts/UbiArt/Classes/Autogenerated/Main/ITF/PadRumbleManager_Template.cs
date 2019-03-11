using UnityEngine;

namespace UbiArt.ITF {
	public partial class PadRumbleManager_Template : TemplateObj {
		[Serialize("rumbles")] public CList<PadRumble> rumbles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(rumbles));
		}
		public override uint? ClassCRC => 0xCBC543B4;
	}
}

