using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_UIMenuScroll_Template : UIMenuBasic_Template {
		[Serialize("defaultScrollingActor")] public Path defaultScrollingActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultScrollingActor));
		}
		public override uint? ClassCRC => 0xBE464DBF;
	}
}

