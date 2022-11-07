namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionStun_Template : BTAction_Template {
		public float timeBeforeDeath;
		public bool useDeathTimer;
		public StringID animStun;
		public StringID animStunLoop;
		public StringID animRestor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeBeforeDeath = s.Serialize<float>(timeBeforeDeath, name: "timeBeforeDeath");
			useDeathTimer = s.Serialize<bool>(useDeathTimer, name: "useDeathTimer");
			animStun = s.SerializeObject<StringID>(animStun, name: "animStun");
			animStunLoop = s.SerializeObject<StringID>(animStunLoop, name: "animStunLoop");
			animRestor = s.SerializeObject<StringID>(animRestor, name: "animRestor");
		}
		public override uint? ClassCRC => 0x4D831DDD;
	}
}

