namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ScreenBorderMissileComponent : ActorComponent {
		public ScreenBorder border;
		public float borderOffset;
		public float corridorWidth;
		public float corridorSmooth;
		public float waitingMaxDuration;
		public float fireShakeDuration;
		public float fireShakeAmplitude;
		public uint fireShakeCount;
		public float fireSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			border = s.Serialize<ScreenBorder>(border, name: "border");
			borderOffset = s.Serialize<float>(borderOffset, name: "borderOffset");
			corridorWidth = s.Serialize<float>(corridorWidth, name: "corridorWidth");
			corridorSmooth = s.Serialize<float>(corridorSmooth, name: "corridorSmooth");
			waitingMaxDuration = s.Serialize<float>(waitingMaxDuration, name: "waitingMaxDuration");
			fireShakeDuration = s.Serialize<float>(fireShakeDuration, name: "fireShakeDuration");
			fireShakeAmplitude = s.Serialize<float>(fireShakeAmplitude, name: "fireShakeAmplitude");
			fireShakeCount = s.Serialize<uint>(fireShakeCount, name: "fireShakeCount");
			fireSpeed = s.Serialize<float>(fireSpeed, name: "fireSpeed");
		}
		public enum ScreenBorder {
			[Serialize("ScreenBorder_Left"  )] Left = 0,
			[Serialize("ScreenBorder_Right" )] Right = 1,
			[Serialize("ScreenBorder_Bottom")] Bottom = 2,
			[Serialize("ScreenBorder_Top"   )] Top = 3,
		}
		public override uint? ClassCRC => 0x10DD06F8;
	}
}

