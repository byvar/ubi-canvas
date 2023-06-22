namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DuckPlugPlayableController : RO2_ActorPlugTransfoController {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF4D945A2;
	}
}

