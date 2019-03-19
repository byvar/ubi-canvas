using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhysForceModifierBox_Template : PhysForceModifier_Template {
		[Serialize("width" )] public float width;
		[Serialize("height")] public float height;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(width));
			SerializeField(s, nameof(height));
		}
		public override uint? ClassCRC => 0x1E5ABFE3;
	}
}

