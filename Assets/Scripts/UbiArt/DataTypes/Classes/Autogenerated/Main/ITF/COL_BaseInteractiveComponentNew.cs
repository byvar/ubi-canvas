namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BaseInteractiveComponentNew : ActorComponent {
		public CListO<Generic<COL_BaseInteraction>> interactions;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			interactions = s.SerializeObject<CListO<Generic<COL_BaseInteraction>>>(interactions, name: "interactions");
		}
		public override uint? ClassCRC => 0xB26B4437;
	}
}

