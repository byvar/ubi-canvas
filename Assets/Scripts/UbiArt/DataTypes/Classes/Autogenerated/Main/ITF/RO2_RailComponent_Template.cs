namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RailComponent_Template : ActorComponent_Template {
		public float speedMax = 1f;
		public float reboundFriction = 1f;
		public bool circleMode;
		public float radius = 1f;
		public Angle initAngle;
		public bool useSnap;
		public float snapTolerance = 0.1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speedMax = s.Serialize<float>(speedMax, name: "speedMax");
			reboundFriction = s.Serialize<float>(reboundFriction, name: "reboundFriction");
			circleMode = s.Serialize<bool>(circleMode, name: "circleMode");
			radius = s.Serialize<float>(radius, name: "radius");
			initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
			useSnap = s.Serialize<bool>(useSnap, name: "useSnap");
			snapTolerance = s.Serialize<float>(snapTolerance, name: "snapTolerance");
		}
		public override uint? ClassCRC => 0x4C430640;
	}
}

