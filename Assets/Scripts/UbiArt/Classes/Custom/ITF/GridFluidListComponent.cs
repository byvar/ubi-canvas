using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GridFluidListComponent : ActorComponent {
		[Serialize("GridList")] public CList<GFX_GridFluid> GridList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(GridList));
			}
		}
		public override uint? ClassCRC => 0xFCDDDCBC;
	}
}

