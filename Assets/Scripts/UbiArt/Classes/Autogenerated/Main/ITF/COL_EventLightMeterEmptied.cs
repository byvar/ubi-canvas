using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventLightMeterEmptied : CSerializable {
		[Serialize("sender")] public Placeholder sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
		}
		public override uint? ClassCRC => 0xF1FBF8E8;
	}
}

