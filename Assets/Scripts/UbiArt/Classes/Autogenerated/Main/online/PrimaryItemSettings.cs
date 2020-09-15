using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class PrimaryItemSettings : CSerializable {
		public uint amount;
		public float reduction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			amount = s.Serialize<uint>(amount, name: "amount");
			reduction = s.Serialize<float>(reduction, name: "reduction");
		}
	}
}

