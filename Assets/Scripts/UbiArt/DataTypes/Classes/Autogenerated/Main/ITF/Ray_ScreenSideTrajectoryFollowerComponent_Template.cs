namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_ScreenSideTrajectoryFollowerComponent_Template : TrajectoryFollowerComponent_Template {
		public float distanceFromSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceFromSide = s.Serialize<float>(distanceFromSide, name: "distanceFromSide");
		}
		public override uint? ClassCRC => 0x43F707F7;
	}
}

