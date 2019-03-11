using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIScrollbar_Template : UIComponent_Template {
		[Serialize("styles")] public CList<UIScrollbar_Template.Style> styles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(styles));
		}
		public override uint? ClassCRC => 0x03848233;
	}
}

