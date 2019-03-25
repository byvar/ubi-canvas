using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_MirrorParam : CSerializable {
		[Serialize("use"    )] public bool use;
		[Serialize("offsetX")] public float offsetX;
		[Serialize("offsetY")] public float offsetY;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(use), boolAsByte: true);
			} else {
				SerializeField(s, nameof(use));
			}
			SerializeField(s, nameof(offsetX));
			SerializeField(s, nameof(offsetY));
		}
	}
}

