using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class ConvertibleBranchComponent : BezierBranchComponent {
		[Serialize("seed")] public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				SerializeField(s, nameof(seed));
			}
		}
		public override uint? ClassCRC => 0xAFC1D751;
	}
}

