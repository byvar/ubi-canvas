namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIPerformHitPolylinePunchAction_Template : Ray_AIPerformHitAction_Template {
		public Angle dirOffset;
		public int hitEnvironment;
		public float memorizeHitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dirOffset = s.SerializeObject<Angle>(dirOffset, name: "dirOffset");
			hitEnvironment = s.Serialize<int>(hitEnvironment, name: "hitEnvironment");
			memorizeHitTime = s.Serialize<float>(memorizeHitTime, name: "memorizeHitTime");
		}
		public override uint? ClassCRC => 0x7F519AE1;
	}
}

