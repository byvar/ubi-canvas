using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PersistentGameData_Level : CSerializable {
		public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
		}
		public override uint? ClassCRC => 0xCE3AADF3;
	}
}

