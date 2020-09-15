using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIScrollbar_Template : UIComponent_Template {
		public CList<UIScrollbar_Template.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			styles = s.SerializeObject<CList<UIScrollbar_Template.Style>>(styles, name: "styles");
		}
		public override uint? ClassCRC => 0x03848233;

		public partial class Style : CSerializable {
		}
	}
}

