using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBonusSkullBehavior_Template : TemplateAIBehavior {
		public float defaultSizePercent;
		public float maxSizePercent;
		public float pulseDuration;
		public float maxSizeDuration;
		public float standDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			defaultSizePercent = s.Serialize<float>(defaultSizePercent, name: "defaultSizePercent");
			maxSizePercent = s.Serialize<float>(maxSizePercent, name: "maxSizePercent");
			pulseDuration = s.Serialize<float>(pulseDuration, name: "pulseDuration");
			maxSizeDuration = s.Serialize<float>(maxSizeDuration, name: "maxSizeDuration");
			standDuration = s.Serialize<float>(standDuration, name: "standDuration");
		}
		public override uint? ClassCRC => 0xE3BED5A2;
	}
}

