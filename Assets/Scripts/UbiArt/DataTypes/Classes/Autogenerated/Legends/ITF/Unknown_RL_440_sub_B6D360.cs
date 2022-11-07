namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_440_sub_B6D360 : ActorComponent {
		public int lockWithTeensy;
		public float detectRange;
		public StringID worldTag;
		public Enum_LockType LockType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				lockWithTeensy = s.Serialize<int>(lockWithTeensy, name: "lockWithTeensy");
				detectRange = s.Serialize<float>(detectRange, name: "detectRange");
				worldTag = s.SerializeObject<StringID>(worldTag, name: "worldTag");
				LockType = s.Serialize<Enum_LockType>(LockType, name: "LockType");
			}
		}
		public enum Enum_LockType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x6DED949C;
	}
}

