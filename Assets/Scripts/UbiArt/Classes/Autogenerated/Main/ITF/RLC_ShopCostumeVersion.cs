using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ShopCostumeVersion : CSerializable {
		[Serialize("costumeID"   )] public StringID costumeID;
		[Serialize("tradeVersion")] public uint tradeVersion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(costumeID));
			SerializeField(s, nameof(tradeVersion));
		}
	}
}

