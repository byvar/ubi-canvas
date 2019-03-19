using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class GravityComponent_Template : PhysForceModifierComponent_Template {
		[Serialize("gravityAreas")] public CList<PhysForceModifier_Template> gravityAreas;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravityAreas));
		}
		public override uint? ClassCRC => 0xCB68B674;
	}
}

