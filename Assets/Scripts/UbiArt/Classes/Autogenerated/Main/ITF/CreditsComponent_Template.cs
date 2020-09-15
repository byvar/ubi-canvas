using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class CreditsComponent_Template : CSerializable {
		public CList<FontTextArea.Style> styles;
		public CList<CreditsDatum> textdata;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			styles = s.SerializeObject<CList<FontTextArea.Style>>(styles, name: "styles");
			textdata = s.SerializeObject<CList<CreditsDatum>>(textdata, name: "textdata");
		}
		public override uint? ClassCRC => 0x336C5A74;
	}
}

