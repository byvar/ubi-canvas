using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LaserDetectorComponent : ActorComponent {
		public float Length;
		public float DetectedSizeEffect;
		public float DelaiInactive;
		public bool LaserSendPafAlone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Length = s.Serialize<float>(Length, name: "Length");
			DetectedSizeEffect = s.Serialize<float>(DetectedSizeEffect, name: "DetectedSizeEffect");
			DelaiInactive = s.Serialize<float>(DelaiInactive, name: "DelaiInactive");
			LaserSendPafAlone = s.Serialize<bool>(LaserSendPafAlone, name: "LaserSendPafAlone");
		}
		public override uint? ClassCRC => 0xD6AE6B90;
	}
}

