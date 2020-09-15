using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_RadialParam : CSerializable {
		[Serialize("use"         )] public bool use;
		[Serialize("centerOffset")] public Vec2d centerOffset;
		[Serialize("strength"    )] public float strength;
		[Serialize("size"        )] public float size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(use), boolAsByte: true);
			} else {
				SerializeField(s, nameof(use));
			}
			SerializeField(s, nameof(centerOffset));
			SerializeField(s, nameof(strength));
			SerializeField(s, nameof(size));
		}
	}
}

