using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class PrimaryItemSettings : CSerializable {
		[Serialize("amount"   )] public uint amount;
		[Serialize("reduction")] public float reduction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(amount));
			SerializeField(s, nameof(reduction));
		}
	}
}

