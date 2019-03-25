using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_RefractionParam : CSerializable {
		[Serialize("use")] public bool use;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(use), boolAsByte: true);
			} else {
				SerializeField(s, nameof(use));
			}
		}
	}
}

