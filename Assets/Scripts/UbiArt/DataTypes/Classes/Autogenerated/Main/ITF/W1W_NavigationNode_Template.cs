namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_NavigationNode_Template : TrajectoryNodeComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD374ACE9;
	}
}

