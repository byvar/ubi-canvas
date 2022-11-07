namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class BoxInterpolatorComponent : InterpolatorComponent {
		public AABB innerBox;
		public AABB outerBox;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				innerBox = s.SerializeObject<AABB>(innerBox, name: "innerBox");
				outerBox = s.SerializeObject<AABB>(outerBox, name: "outerBox");
			}
		}
		public override uint? ClassCRC => 0xF51360DA;
	}
}

