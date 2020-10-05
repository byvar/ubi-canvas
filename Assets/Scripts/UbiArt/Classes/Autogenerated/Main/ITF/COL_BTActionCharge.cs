using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionCharge : CSerializable {
		public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
		}
		public override uint? ClassCRC => 0x03B598BA;
	}
}

