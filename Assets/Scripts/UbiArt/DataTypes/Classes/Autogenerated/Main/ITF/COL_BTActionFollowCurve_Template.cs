namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionFollowCurve_Template : CSerializable {
		public StringID name;
		[Description("Anim used when moving along the curve")]
		public StringID animMove;
		[Description("Anim used when not moving")]
		public StringID animIdle;
		[Description("Speed when moving along curve")]
		public float moveSpeed;
		[Description("Duration of the idle")]
		public float idleDuration;
		public bool followCurveAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			animMove = s.SerializeObject<StringID>(animMove, name: "animMove");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
			moveSpeed = s.Serialize<float>(moveSpeed, name: "moveSpeed");
			idleDuration = s.Serialize<float>(idleDuration, name: "idleDuration");
			followCurveAngle = s.Serialize<bool>(followCurveAngle, name: "followCurveAngle", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x5F5BD095;
	}
}

