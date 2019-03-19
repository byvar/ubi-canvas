using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WorldMapUIItem_Template : CSerializable {
		[Serialize("locationUnlockFX")] public StringID locationUnlockFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(locationUnlockFX));
		}
		public override uint? ClassCRC => 0x82555443;
	}
}

