using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_EggButton : RLC_BasicAdventureButton {
		public GFXPrimitiveParam EggOverrideGFXPrimitiveParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			EggOverrideGFXPrimitiveParams = s.SerializeObject<GFXPrimitiveParam>(EggOverrideGFXPrimitiveParams, name: "EggOverrideGFXPrimitiveParams");
		}
		public override uint? ClassCRC => 0xF09BB9AF;
	}
}

