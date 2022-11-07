namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_38759_sub_A04790 : CSerializable {
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
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
	}
}
