namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionStilts_Template : BTAction_Template {
		public bool useArmor;
		public float speedFall = 1f;
		public StringID animBreak_To_0;
		public StringID animBreak_To_1;
		public StringID animBreak_To_2;
		public StringID animFall_To_0;
		public StringID animFall_To_1;
		public StringID animFall_To_2;
		public StringID animReception_To_0;
		public StringID animReception_To_1;
		public StringID animReception_To_2;
		public Vec2d offsetFxPos_Level_0;
		public Vec2d offsetFxPos_Level_1;
		public Vec2d offsetFxPos_Level_2;
		public StringID animLanding;
		public StringID breakFxName;
		public StringID break02FxName;
		public StringID break03FxName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useArmor = s.Serialize<bool>(useArmor, name: "useArmor");
			speedFall = s.Serialize<float>(speedFall, name: "speedFall");
			animBreak_To_0 = s.SerializeObject<StringID>(animBreak_To_0, name: "animBreak_To_0");
			animBreak_To_1 = s.SerializeObject<StringID>(animBreak_To_1, name: "animBreak_To_1");
			animBreak_To_2 = s.SerializeObject<StringID>(animBreak_To_2, name: "animBreak_To_2");
			animFall_To_0 = s.SerializeObject<StringID>(animFall_To_0, name: "animFall_To_0");
			animFall_To_1 = s.SerializeObject<StringID>(animFall_To_1, name: "animFall_To_1");
			animFall_To_2 = s.SerializeObject<StringID>(animFall_To_2, name: "animFall_To_2");
			animReception_To_0 = s.SerializeObject<StringID>(animReception_To_0, name: "animReception_To_0");
			animReception_To_1 = s.SerializeObject<StringID>(animReception_To_1, name: "animReception_To_1");
			animReception_To_2 = s.SerializeObject<StringID>(animReception_To_2, name: "animReception_To_2");
			offsetFxPos_Level_0 = s.SerializeObject<Vec2d>(offsetFxPos_Level_0, name: "offsetFxPos_Level_0");
			offsetFxPos_Level_1 = s.SerializeObject<Vec2d>(offsetFxPos_Level_1, name: "offsetFxPos_Level_1");
			offsetFxPos_Level_2 = s.SerializeObject<Vec2d>(offsetFxPos_Level_2, name: "offsetFxPos_Level_2");
			animLanding = s.SerializeObject<StringID>(animLanding, name: "animLanding");
			breakFxName = s.SerializeObject<StringID>(breakFxName, name: "breakFxName");
			break02FxName = s.SerializeObject<StringID>(break02FxName, name: "break02FxName");
			break03FxName = s.SerializeObject<StringID>(break03FxName, name: "break03FxName");
		}
		public override uint? ClassCRC => 0xAA96F821;
	}
}

