namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class GridFluidListComponent : ActorComponent {
		public CListO<GFX_GridFluid> GridList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				GridList = s.SerializeObject<CListO<GFX_GridFluid>>(GridList, name: "GridList");
			}
		}
		public override uint? ClassCRC => 0xFCDDDCBC;
	}
}

