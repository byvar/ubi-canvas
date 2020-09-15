using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PhysBodyComponent_Template : CSerializable {
		public Placeholder physShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			physShape = s.SerializeObject<Placeholder>(physShape, name: "physShape");
		}
		public override uint? ClassCRC => 0xFF59805E;
	}
}

