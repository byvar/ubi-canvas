using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ElCrapoBehaviorComponent_Template : RO2_AIComponent_Template {
		public float jumpSpeed;
		public float bounceSpeed;
		public float bumperSpeed;
		public float maxSpeed;
		public float airControl;
		public float fullSpeedThreshold;
		public float dangerousContactHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpSpeed = s.Serialize<float>(jumpSpeed, name: "jumpSpeed");
			bounceSpeed = s.Serialize<float>(bounceSpeed, name: "bounceSpeed");
			bumperSpeed = s.Serialize<float>(bumperSpeed, name: "bumperSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			airControl = s.Serialize<float>(airControl, name: "airControl");
			fullSpeedThreshold = s.Serialize<float>(fullSpeedThreshold, name: "fullSpeedThreshold");
			dangerousContactHeight = s.Serialize<float>(dangerousContactHeight, name: "dangerousContactHeight");
		}
		public override uint? ClassCRC => 0xFBCC8031;
	}
}

