namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class HiddenComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE49A1EA7;
	}
}

