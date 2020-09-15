using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIFruitTrapComponent_Template : ActorComponent_Template {
		public float delay;
		public float stayDownDelay;
		public float weightThreshold;
		public bool defaultPosIsUp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			delay = s.Serialize<float>(delay, name: "delay");
			stayDownDelay = s.Serialize<float>(stayDownDelay, name: "stayDownDelay");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			defaultPosIsUp = s.Serialize<bool>(defaultPosIsUp, name: "defaultPosIsUp");
		}
		public override uint? ClassCRC => 0xFDFC9D5C;
	}
}

