using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PointOfInterestComponent_Template : CSerializable {
		public Placeholder shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Placeholder>(shape, name: "shape");
		}
		public override uint? ClassCRC => 0x7E749CC3;
	}
}

