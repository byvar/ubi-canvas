namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class ActorPlugAIController : ActorPlugBaseController {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD78F570A;
	}
}

