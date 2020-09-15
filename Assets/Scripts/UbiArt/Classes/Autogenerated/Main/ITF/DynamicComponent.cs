using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class DynamicComponent : PhysComponent {
		public CArray<Generic<AbstractDynModifier>> Modifiers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Modifiers = s.SerializeObject<CArray<Generic<AbstractDynModifier>>>(Modifiers, name: "Modifiers");
		}
		public override uint? ClassCRC => 0x9F056DB1;
	}
}

