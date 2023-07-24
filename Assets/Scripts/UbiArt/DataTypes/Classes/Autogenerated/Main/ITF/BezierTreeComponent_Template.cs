namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierTreeComponent_Template : ActorComponent_Template {
		public BezierTree_Template tree = new BezierTree_Template();

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			// Not serialized as an object with a group, just raw!
			tree.SerializeEmbedded(s);
		}
		public override uint? ClassCRC => 0x7C0C114C;
	}
}

