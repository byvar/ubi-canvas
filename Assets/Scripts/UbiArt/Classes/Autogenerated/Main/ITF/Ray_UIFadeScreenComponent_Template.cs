using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_UIFadeScreenComponent_Template : UIComponent_Template {
		public CArray<UIFadeEntry> types;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			types = s.SerializeObject<CArray<UIFadeEntry>>(types, name: "types");
		}
		public override uint? ClassCRC => 0xB8D48AC1;
	}
}

