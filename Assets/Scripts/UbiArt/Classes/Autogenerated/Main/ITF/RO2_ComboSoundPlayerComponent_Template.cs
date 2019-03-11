using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ComboSoundPlayerComponent_Template : ActorComponent_Template {
		[Serialize("comboSound"         )] public StringID comboSound;
		[Serialize("maxTimeBetweenCombo")] public float maxTimeBetweenCombo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(comboSound));
			SerializeField(s, nameof(maxTimeBetweenCombo));
		}
		public override uint? ClassCRC => 0x0D6F6344;
	}
}

