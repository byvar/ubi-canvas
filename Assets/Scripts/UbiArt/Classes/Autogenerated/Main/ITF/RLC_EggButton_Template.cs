using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_EggButton_Template : RLC_BasicAdventureButton_Template {
		public bool EggUnlocked_ForceDontUseGlobalLighting;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			EggUnlocked_ForceDontUseGlobalLighting = s.Serialize<bool>(EggUnlocked_ForceDontUseGlobalLighting, name: "EggUnlocked_ForceDontUseGlobalLighting");
		}
		public override uint? ClassCRC => 0x94B396F2;
	}
}

