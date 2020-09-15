using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenTranslationSine_Template : TweenTranslation_Template {
		[Serialize("movement"   )] public Vec3d movement;
		[Serialize("amplitude"  )] public float amplitude;
		[Serialize("cycleCount" )] public float cycleCount;
		[Serialize("cycleOffset")] public float cycleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(movement));
			SerializeField(s, nameof(amplitude));
			SerializeField(s, nameof(cycleCount));
			SerializeField(s, nameof(cycleOffset));
		}
		public override uint? ClassCRC => 0xA6CFC699;
	}
}

