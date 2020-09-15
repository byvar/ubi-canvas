using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_DynamicStoreItem : CSerializable {
		public uint msdkItemId;
		public uint locId;
		public uint version;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			msdkItemId = s.Serialize<uint>(msdkItemId, name: "msdkItemId");
			locId = s.Serialize<uint>(locId, name: "locId");
			version = s.Serialize<uint>(version, name: "version");
		}
		public override uint? ClassCRC => 0x5161A81E;
	}
}

