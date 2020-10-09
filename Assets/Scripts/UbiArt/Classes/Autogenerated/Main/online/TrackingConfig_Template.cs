using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class TrackingConfig_Template : ITF.TemplateObj {
		public ITF.StatRewriter Rewriter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Rewriter = s.SerializeObject<ITF.StatRewriter>(Rewriter, name: "Rewriter");
		}
		public override uint? ClassCRC => 0x26F34891;
	}
}

