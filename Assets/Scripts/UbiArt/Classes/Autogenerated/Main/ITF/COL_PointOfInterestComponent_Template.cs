using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PointOfInterestComponent_Template : CSerializable {
		[Serialize("shape")] public Placeholder shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shape));
		}
		public override uint? ClassCRC => 0x7E749CC3;
	}
}

