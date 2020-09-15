using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionSleep_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID animSleep;
		public StringID animWakeUp;
		public StringID animGotoSleep;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			animSleep = s.SerializeObject<StringID>(animSleep, name: "animSleep");
			animWakeUp = s.SerializeObject<StringID>(animWakeUp, name: "animWakeUp");
			animGotoSleep = s.SerializeObject<StringID>(animGotoSleep, name: "animGotoSleep");
		}
		public override uint? ClassCRC => 0xE9104191;
	}
}

