namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_TutoBallComponent_Template : ActorComponent_Template {
		public Path tutoTapPath;
		public Path tutoSwipePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tutoTapPath = s.SerializeObject<Path>(tutoTapPath, name: "tutoTapPath");
			tutoSwipePath = s.SerializeObject<Path>(tutoSwipePath, name: "tutoSwipePath");
		}
		public override uint? ClassCRC => 0xC0641AF5;
	}
}

