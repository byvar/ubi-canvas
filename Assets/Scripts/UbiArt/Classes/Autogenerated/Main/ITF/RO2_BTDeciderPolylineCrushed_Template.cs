using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTDeciderPolylineCrushed_Template : BTDecider_Template {
		[Serialize("speedThreshold"   )] public float speedThreshold;
		[Serialize("restartOnNewCrush")] public bool restartOnNewCrush;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speedThreshold));
			SerializeField(s, nameof(restartOnNewCrush));
		}
		public override uint? ClassCRC => 0x43BCE42C;
	}
}

