using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class UIItemOnOff : UIItemBasic {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			selectTextStyle = s.Serialize<uint>(selectTextStyle, name: "selectTextStyle"); // Yes, the same field is serialized a second time. Points to the same thing.
			selectAnimMeshVertex = s.SerializeObject<CList<StringID>>(selectAnimMeshVertex, name: "selectAnimMeshVertex");
		}
		public override uint? ClassCRC => 0x38632292;
	}
}

