namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ActorPlugTransfoController : ActorPlugPlayableController {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE559EB5A;
	}
}

