using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GridFluidModifierComponent : ActorComponent {
		[Serialize("Reinit"       )] public bool Reinit;
		[Serialize("FluidModifier")] public GFX_GridFluidModifierList FluidModifier;
		[Serialize("Margin"       )] public AABB Margin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Reinit));
				SerializeField(s, nameof(FluidModifier));
				SerializeField(s, nameof(Margin));
			}
		}

		public override uint? ClassCRC => 0xB8D8FE0C;
	}
}

