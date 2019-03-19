using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CraftingMenu_Template : CSerializable {
		[Serialize("craftingAvailableFX")] public StringID craftingAvailableFX;
		[Serialize("craftSuccessFX"     )] public StringID craftSuccessFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(craftingAvailableFX));
			SerializeField(s, nameof(craftSuccessFX));
		}
		public override uint? ClassCRC => 0xCCF3ADC5;
	}
}

