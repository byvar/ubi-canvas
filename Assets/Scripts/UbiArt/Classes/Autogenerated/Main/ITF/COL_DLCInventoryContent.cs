using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCInventoryContent : CSerializable {
		[Serialize("template"    )] public Path template;
		[Serialize("inventoryLoc")] public Placeholder inventoryLoc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(template));
			SerializeField(s, nameof(inventoryLoc));
		}
		public override uint? ClassCRC => 0xB178427B;
	}
}

