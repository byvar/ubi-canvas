using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_RO_0_sub_5B2C20 : CSerializable {
		[Serialize("state")] public uint state;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(state));
		}
		public override uint? ClassCRC => 0x804FEEEE;
	}
}

