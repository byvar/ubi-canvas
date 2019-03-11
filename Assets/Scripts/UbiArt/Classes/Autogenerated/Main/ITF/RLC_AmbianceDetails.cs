using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_AmbianceDetails : CSerializable {
		[Serialize("AmbianceDetailsId")] public StringID AmbianceDetailsId;
		[Serialize("Bank"             )] public PathRef Bank;
		[Serialize("WwiseGUID_Start"  )] public StringID WwiseGUID_Start;
		[Serialize("WwiseGUID_Stop"   )] public StringID WwiseGUID_Stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AmbianceDetailsId));
			SerializeField(s, nameof(Bank));
			SerializeField(s, nameof(WwiseGUID_Start));
			SerializeField(s, nameof(WwiseGUID_Stop));
		}
		public override uint? ClassCRC => 0xA1C6ED6C;
	}
}

