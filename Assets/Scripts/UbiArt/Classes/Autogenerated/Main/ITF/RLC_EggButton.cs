using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_EggButton : RLC_BasicAdventureButton {
		[Serialize("EggOverrideGFXPrimitiveParams")] public GFXPrimitiveParam EggOverrideGFXPrimitiveParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(EggOverrideGFXPrimitiveParams));
		}
		public override uint? ClassCRC => 0xF09BB9AF;
	}
}

