using UnityEngine;

namespace UbiArt.online {
	public partial class TrackingConfig_Template : ITF.TemplateObj {
		[Serialize("Rewriter")] public ITF.StatRewriter Rewriter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Rewriter));
		}
		public override uint? ClassCRC => 0x26F34891;
	}
}

