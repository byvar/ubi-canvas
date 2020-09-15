using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_UIFadeScreenComponent_Template : UIComponent_Template {
		public CList<UIFadeEntry> types;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			types = s.SerializeObject<CList<UIFadeEntry>>(types, name: "types");
			animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
		}
		public override uint? ClassCRC => 0xC7834786;
	}
}

