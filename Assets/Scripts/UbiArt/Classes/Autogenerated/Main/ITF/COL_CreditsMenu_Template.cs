using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CreditsMenu_Template : CSerializable {
		[Serialize("creditsTexts")] public Placeholder creditsTexts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creditsTexts));
		}
		public override uint? ClassCRC => 0x2EB95851;
	}
}

