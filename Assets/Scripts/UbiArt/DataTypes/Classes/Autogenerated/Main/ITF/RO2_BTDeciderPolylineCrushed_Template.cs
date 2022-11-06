using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTDeciderPolylineCrushed_Template : BTDecider_Template {
		public float speedThreshold;
		public bool restartOnNewCrush;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speedThreshold = s.Serialize<float>(speedThreshold, name: "speedThreshold");
			restartOnNewCrush = s.Serialize<bool>(restartOnNewCrush, name: "restartOnNewCrush");
		}
		public override uint? ClassCRC => 0x43BCE42C;
	}
}

