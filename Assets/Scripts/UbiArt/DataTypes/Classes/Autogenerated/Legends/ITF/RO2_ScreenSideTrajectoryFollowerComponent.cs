namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ScreenSideTrajectoryFollowerComponent : TrajectoryFollowerComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6863D6CA;
	}
}

