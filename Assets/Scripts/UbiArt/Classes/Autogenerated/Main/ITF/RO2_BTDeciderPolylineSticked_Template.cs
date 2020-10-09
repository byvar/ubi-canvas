using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTDeciderPolylineSticked_Template : BTDecider_Template {
		public bool sticked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sticked = s.Serialize<bool>(sticked, name: "sticked");
		}
		public override uint? ClassCRC => 0x43861DF9;
	}
}

