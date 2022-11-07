namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ActorPlugPlayableController : ActorPlugBaseController {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEF4B65C0;
	}
}

