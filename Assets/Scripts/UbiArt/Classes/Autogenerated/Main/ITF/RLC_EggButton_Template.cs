using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_EggButton_Template : RLC_BasicAdventureButton_Template {
		[Serialize("EggUnlocked_ForceDontUseGlobalLighting")] public bool EggUnlocked_ForceDontUseGlobalLighting;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(EggUnlocked_ForceDontUseGlobalLighting));
		}
		public override uint? ClassCRC => 0x94B396F2;
	}
}

