namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionDash_Template : BTAction_Template {
		public StringID animAnticip;
		public StringID animDash;
		public StringID animEndDash;
		public StringID animDashSuccess;
		public StringID animHitWall;
		public StringID animPullSword;
		public StringID animPullSwordToStand;
		public StringID animHoleStop;
		public float distMaxCharge = 10f;
		public float timeTired;
		public float timeAnticip;
		public float timePullSword;
		public Spline dashEfficiency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animAnticip = s.SerializeObject<StringID>(animAnticip, name: "animAnticip");
			animDash = s.SerializeObject<StringID>(animDash, name: "animDash");
			animEndDash = s.SerializeObject<StringID>(animEndDash, name: "animEndDash");
			animDashSuccess = s.SerializeObject<StringID>(animDashSuccess, name: "animDashSuccess");
			animHitWall = s.SerializeObject<StringID>(animHitWall, name: "animHitWall");
			animPullSword = s.SerializeObject<StringID>(animPullSword, name: "animPullSword");
			animPullSwordToStand = s.SerializeObject<StringID>(animPullSwordToStand, name: "animPullSwordToStand");
			animHoleStop = s.SerializeObject<StringID>(animHoleStop, name: "animHoleStop");
			distMaxCharge = s.Serialize<float>(distMaxCharge, name: "distMaxCharge");
			timeTired = s.Serialize<float>(timeTired, name: "timeTired");
			timeAnticip = s.Serialize<float>(timeAnticip, name: "timeAnticip");
			timePullSword = s.Serialize<float>(timePullSword, name: "timePullSword");
			dashEfficiency = s.SerializeObject<Spline>(dashEfficiency, name: "dashEfficiency");
		}
		public override uint? ClassCRC => 0xCE1C0FF4;
	}
}

