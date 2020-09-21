using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class CreditsComponent_Template : CSerializable {
		public CListO<FontTextArea.Style> styles;
		public CListO<CreditsDatum> textdata;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			styles = s.SerializeObject<CListO<FontTextArea.Style>>(styles, name: "styles");
			textdata = s.SerializeObject<CListO<CreditsDatum>>(textdata, name: "textdata");
		}
		public override uint? ClassCRC => 0x336C5A74;
	}
}

