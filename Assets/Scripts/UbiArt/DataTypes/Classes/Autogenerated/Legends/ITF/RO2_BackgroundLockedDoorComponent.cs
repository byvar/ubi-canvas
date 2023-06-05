namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BackgroundLockedDoorComponent : ActorComponent {
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
			[Serialize("LockType_retro1")] retro1 = 0,
			[Serialize("LockType_retro2")] retro2 = 1,
			[Serialize("LockType_costume")] costume = 2,
		}
		public override uint? ClassCRC => 0x6DED949C;
	}
}

