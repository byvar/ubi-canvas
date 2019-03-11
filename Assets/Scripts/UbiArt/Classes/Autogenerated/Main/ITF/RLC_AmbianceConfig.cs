using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AmbianceConfig : CSerializable {
		[Serialize("AmbianceDetailsId")] public StringID AmbianceDetailsId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AmbianceDetailsId));
		}
		public override uint? ClassCRC => 0xBC4BC469;
	}
}

