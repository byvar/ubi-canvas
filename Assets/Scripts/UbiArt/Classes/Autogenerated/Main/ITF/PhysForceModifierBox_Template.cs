using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PhysForceModifierBox_Template : PhysForceModifier_Template {
		public float width;
		public float height;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			width = s.Serialize<float>(width, name: "width");
			height = s.Serialize<float>(height, name: "height");
		}
		public override uint? ClassCRC => 0x1E5ABFE3;
	}
}

