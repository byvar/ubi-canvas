namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LaserDetectorComponent : ActorComponent {
		public float Length = 1f;
		public float DetectedSizeEffect = 0.6f;
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

