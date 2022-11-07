namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class SubAnchorComponent_Template : ActorComponent_Template {
		public CListO<SubAnchor_Template> subAnchors;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			subAnchors = s.SerializeObject<CListO<SubAnchor_Template>>(subAnchors, name: "subAnchors");
		}
		public override uint? ClassCRC => 0x839E4DD5;
	}
}

