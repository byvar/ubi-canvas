using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCTutorialContent : CSerializable {
		public Path template;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			template = s.SerializeObject<Path>(template, name: "template");
		}
		public override uint? ClassCRC => 0x52B84DE1;
	}
}

