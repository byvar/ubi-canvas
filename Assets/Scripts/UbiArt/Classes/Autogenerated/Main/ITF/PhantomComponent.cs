using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhantomComponent : ShapeComponent {
		public CArray<float> depthOffsets;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RA) {
				depthOffsets = s.SerializeObject<CArray<float>>(depthOffsets, name: "depthOffsets");
			}
		}
		public override uint? ClassCRC => 0x2B541820;
	}
}

