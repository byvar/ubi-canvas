using UnityEngine;

namespace UbiArt.ITF {
	public partial class CreditsComponent_Template : CSerializable {
		[Serialize("styles"  )] public CList<FontTextArea.Style> styles;
		[Serialize("textdata")] public CList<CreditsDatum> textdata;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(styles));
			SerializeField(s, nameof(textdata));
		}
		public override uint? ClassCRC => 0x336C5A74;
	}
}

