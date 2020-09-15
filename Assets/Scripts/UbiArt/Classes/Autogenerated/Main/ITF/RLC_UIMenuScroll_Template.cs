using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_UIMenuScroll_Template : UIMenuBasic_Template {
		public Path defaultScrollingActor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultScrollingActor = s.SerializeObject<Path>(defaultScrollingActor, name: "defaultScrollingActor");
		}
		public override uint? ClassCRC => 0xBE464DBF;
	}
}

