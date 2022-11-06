using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCInventoryContent : CSerializable {
		public Path template;
		public Placeholder inventoryLoc;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			template = s.SerializeObject<Path>(template, name: "template");
			inventoryLoc = s.SerializeObject<Placeholder>(inventoryLoc, name: "inventoryLoc");
		}
		public override uint? ClassCRC => 0xB178427B;
	}
}

