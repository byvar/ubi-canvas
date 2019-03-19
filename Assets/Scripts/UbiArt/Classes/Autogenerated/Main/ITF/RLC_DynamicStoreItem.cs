using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_DynamicStoreItem : CSerializable {
		[Serialize("msdkItemId")] public uint msdkItemId;
		[Serialize("locId"     )] public uint locId;
		[Serialize("version"   )] public uint version;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(msdkItemId));
			SerializeField(s, nameof(locId));
			SerializeField(s, nameof(version));
		}
		public override uint? ClassCRC => 0x5161A81E;
	}
}

