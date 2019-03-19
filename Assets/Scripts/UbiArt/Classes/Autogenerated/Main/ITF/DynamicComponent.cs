using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class DynamicComponent : PhysComponent {
		[Serialize("Modifiers")] public CArray<Generic<AbstractDynModifier>> Modifiers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Modifiers));
		}
		public override uint? ClassCRC => 0x9F056DB1;
	}
}

