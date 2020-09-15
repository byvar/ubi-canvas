using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_TileParam : CSerializable {
		public bool use;
		public float repetition;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				use = s.Serialize<bool>(use, name: "use", options: CSerializerObject.Options.BoolAsByte);
			} else {
				use = s.Serialize<bool>(use, name: "use");
			}
			repetition = s.Serialize<float>(repetition, name: "repetition");
		}
	}
}

