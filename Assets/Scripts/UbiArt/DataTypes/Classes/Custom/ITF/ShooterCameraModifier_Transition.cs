namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class ShooterCameraModifier_Transition : CSerializable {
		public Enum_type type;
		public float duration;
		public Vec2d additionalSpeed;
		public float notifyPlayerDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<Enum_type>(type, name: "type");
			duration = s.Serialize<float>(duration, name: "duration");
			additionalSpeed = s.SerializeObject<Vec2d>(additionalSpeed, name: "additionalSpeed");
			notifyPlayerDelay = s.Serialize<float>(notifyPlayerDelay, name: "notifyPlayerDelay");
		}
		public enum Enum_type {
			[Serialize("Linear"    )] Linear = 0,
			[Serialize("AccelDecel")] AccelDecel = 1,
			[Serialize("X2"        )] X2 = 2,
			[Serialize("InvX2"     )] InvX2 = 3,
			[Serialize("X3"        )] X3 = 4,
			[Serialize("InvX3"     )] InvX3 = 5,
		}
	}
}
