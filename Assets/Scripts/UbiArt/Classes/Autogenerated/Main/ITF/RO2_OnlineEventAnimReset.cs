using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_OnlineEventAnimReset : Event {
		public bool tree;
		public bool transition;
		public bool curTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tree = s.Serialize<bool>(tree, name: "tree");
			transition = s.Serialize<bool>(transition, name: "transition");
			curTime = s.Serialize<bool>(curTime, name: "curTime");
		}
		public override uint? ClassCRC => 0xD672B007;
	}
}

