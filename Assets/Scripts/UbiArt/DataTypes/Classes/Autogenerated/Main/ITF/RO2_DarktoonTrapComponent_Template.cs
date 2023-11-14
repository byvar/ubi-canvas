namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_DarktoonTrapComponent_Template : RO2_AIComponent_Template {
		public StringID animIdle;
		public StringID animAttack;
		public StringID animHit;
		public StringID animFall;
		public StringID animStun;
		public float stunDuration = 2f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			animAttack = s.SerializeObject<StringID>(animAttack, name: "animAttack");
			animHit = s.SerializeObject<StringID>(animHit, name: "animHit");
			animFall = s.SerializeObject<StringID>(animFall, name: "animFall");
			animStun = s.SerializeObject<StringID>(animStun, name: "animStun");
			stunDuration = s.Serialize<float>(stunDuration, name: "stunDuration");
		}
		public override uint? ClassCRC => 0x96259FB4;
	}
}

