using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PowerUpDisplay_Template : CSerializable {
		public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			id = s.SerializeObject<StringID>(id, name: "id");
		}
		public override uint? ClassCRC => 0x1D175BED;
	}
}

