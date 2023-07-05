namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ScreenSideTrajectoryFollowerComponent_Template : TrajectoryFollowerComponent_Template {
		public float distanceFromSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceFromSide = s.Serialize<float>(distanceFromSide, name: "distanceFromSide");
		}
		public override uint? ClassCRC => 0xB98E4D8D;
	}
}

