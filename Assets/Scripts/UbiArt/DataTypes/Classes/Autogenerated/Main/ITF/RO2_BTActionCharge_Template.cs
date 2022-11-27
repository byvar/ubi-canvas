namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionCharge_Template : BTAction_Template {
		public StringID animAnticip;
		public StringID animRun;
		public StringID animEndRun;
		public StringID animHitWall;
		public StringID animHoleStop;
		public float distMaxCharge = 10f;
		public float timePatinage;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animAnticip = s.SerializeObject<StringID>(animAnticip, name: "animAnticip");
			animRun = s.SerializeObject<StringID>(animRun, name: "animRun");
			animEndRun = s.SerializeObject<StringID>(animEndRun, name: "animEndRun");
			animHitWall = s.SerializeObject<StringID>(animHitWall, name: "animHitWall");
			animHoleStop = s.SerializeObject<StringID>(animHoleStop, name: "animHoleStop");
			distMaxCharge = s.Serialize<float>(distMaxCharge, name: "distMaxCharge");
			timePatinage = s.Serialize<float>(timePatinage, name: "timePatinage");
		}
		public override uint? ClassCRC => 0x31AC41DC;
	}
}

