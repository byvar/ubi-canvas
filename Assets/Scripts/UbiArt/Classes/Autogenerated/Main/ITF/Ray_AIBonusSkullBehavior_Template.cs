using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBonusSkullBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("defaultSizePercent")] public float defaultSizePercent;
		[Serialize("maxSizePercent"    )] public float maxSizePercent;
		[Serialize("pulseDuration"     )] public float pulseDuration;
		[Serialize("maxSizeDuration"   )] public float maxSizeDuration;
		[Serialize("standDuration"     )] public float standDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(defaultSizePercent));
			SerializeField(s, nameof(maxSizePercent));
			SerializeField(s, nameof(pulseDuration));
			SerializeField(s, nameof(maxSizeDuration));
			SerializeField(s, nameof(standDuration));
		}
		public override uint? ClassCRC => 0xE3BED5A2;
	}
}

