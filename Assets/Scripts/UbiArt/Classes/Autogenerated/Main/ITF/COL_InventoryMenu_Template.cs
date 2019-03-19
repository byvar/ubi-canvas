using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryMenu_Template : CSerializable {
		[Serialize("openLetterFX")] public StringID openLetterFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(openLetterFX));
		}
		public override uint? ClassCRC => 0xBAFFC83F;
	}
}

