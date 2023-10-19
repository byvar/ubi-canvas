namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RevivePointComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x89D4EBBD;
	}
}

