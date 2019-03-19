using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhantomComponent : ShapeComponent {
		[Serialize("depthOffsets"    )] public CArray<float> depthOffsets;
		[Serialize("CArray<float>__0")] public CArray<float> CArray_float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(CArray_float__0));
			} else {
				SerializeField(s, nameof(depthOffsets));
				SerializeField(s, nameof(depthOffsets));
			}
		}
		public override uint? ClassCRC => 0x2B541820;
	}
}

