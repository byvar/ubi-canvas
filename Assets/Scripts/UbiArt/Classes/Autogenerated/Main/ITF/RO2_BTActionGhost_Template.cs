using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionGhost_Template : BTAction_Template {
		public StringID animFlyOpen;
		public StringID animFlyClosed;
		public StringID sparklesFxName;
		public float speed;
		public float distMax;
		public bool isOnFire;
		public bool isStatic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animFlyOpen = s.SerializeObject<StringID>(animFlyOpen, name: "animFlyOpen");
			animFlyClosed = s.SerializeObject<StringID>(animFlyClosed, name: "animFlyClosed");
			sparklesFxName = s.SerializeObject<StringID>(sparklesFxName, name: "sparklesFxName");
			speed = s.Serialize<float>(speed, name: "speed");
			distMax = s.Serialize<float>(distMax, name: "distMax");
			isOnFire = s.Serialize<bool>(isOnFire, name: "isOnFire");
			isStatic = s.Serialize<bool>(isStatic, name: "isStatic");
		}
		public override uint? ClassCRC => 0xC0A90EFA;
	}
}

