using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class UIFadeScreenComponent_Template : UIComponent_Template {
		public CList<UIFadeEntry> types;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			types = s.SerializeObject<CList<UIFadeEntry>>(types, name: "types");
			animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
		}
		public override uint? ClassCRC => 0xAD25C355;
	}
}

