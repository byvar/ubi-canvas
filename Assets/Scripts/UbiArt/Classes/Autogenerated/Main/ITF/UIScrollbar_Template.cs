using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIScrollbar_Template : UIComponent_Template {
		public CListO<UIScrollbar_Template.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			styles = s.SerializeObject<CListO<UIScrollbar_Template.Style>>(styles, name: "styles");
		}
		public override uint? ClassCRC => 0x03848233;

		public partial class Style : CSerializable {
		}
	}
}

