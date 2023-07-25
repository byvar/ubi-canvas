namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BaseInteractiveComponentNew : ActorComponent {
		public CListO<StringID> interactions;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interactions = s.SerializeObject<CListO<StringID>>(interactions, name: "interactions");
		}
		public override uint? ClassCRC => 0xB26B4437;
	}
}

