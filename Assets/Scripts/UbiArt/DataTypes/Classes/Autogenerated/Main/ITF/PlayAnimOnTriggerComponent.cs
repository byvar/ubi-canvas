namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PlayAnimOnTriggerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1BB0CA85;
	}
}

