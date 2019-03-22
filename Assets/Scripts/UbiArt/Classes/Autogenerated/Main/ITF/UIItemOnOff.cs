using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class UIItemOnOff : UIItemBasic {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(selectTextStyle)); // Yes, the same field is serialized a second time. Points to the same thing.
			SerializeField(s, nameof(selectAnimMeshVertex));
		}
		public override uint? ClassCRC => 0x38632292;
	}
}

