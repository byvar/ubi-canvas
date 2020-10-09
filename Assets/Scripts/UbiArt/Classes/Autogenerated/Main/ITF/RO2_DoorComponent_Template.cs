using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DoorComponent_Template : ActorComponent_Template {
		public bool startOpen;
		public float openSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startOpen = s.Serialize<bool>(startOpen, name: "startOpen");
			openSpeed = s.Serialize<float>(openSpeed, name: "openSpeed");
		}
		public override uint? ClassCRC => 0xA84FB414;
	}
}

