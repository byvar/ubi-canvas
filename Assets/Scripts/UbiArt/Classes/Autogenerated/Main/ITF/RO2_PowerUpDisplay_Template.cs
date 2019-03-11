using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PowerUpDisplay_Template : CSerializable {
		[Serialize("id")] public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
		}
		public override uint? ClassCRC => 0x41C1630D;
	}
}

