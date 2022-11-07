namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_SubAnchorComponent : ActorComponent {
		public CListO<Ray_SubAnchor> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnchors = s.SerializeObject<CListO<Ray_SubAnchor>>(subAnchors, name: "subAnchors");
		}
		public override uint? ClassCRC => 0x220C7A1B;
	}
}

