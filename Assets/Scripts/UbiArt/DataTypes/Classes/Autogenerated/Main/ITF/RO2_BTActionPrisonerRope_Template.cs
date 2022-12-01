namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionPrisonerRope_Template : BTAction_Template {
		public StringID animPrisoner;
		public StringID animFree;
		public StringID animThank;
		public StringID animFreeFall;
		public float speedMultiplier = 1f;
		public Vec2d forceSinus;
		public float freqSinus = 1f;
		public uint countLumsReward = 5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animPrisoner = s.SerializeObject<StringID>(animPrisoner, name: "animPrisoner");
			animFree = s.SerializeObject<StringID>(animFree, name: "animFree");
			animThank = s.SerializeObject<StringID>(animThank, name: "animThank");
			animFreeFall = s.SerializeObject<StringID>(animFreeFall, name: "animFreeFall");
			speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
			forceSinus = s.SerializeObject<Vec2d>(forceSinus, name: "forceSinus");
			freqSinus = s.Serialize<float>(freqSinus, name: "freqSinus");
			countLumsReward = s.Serialize<uint>(countLumsReward, name: "countLumsReward");
		}
		public override uint? ClassCRC => 0x38EC6B84;
	}
}

