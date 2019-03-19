using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AFX_RadialParam : CSerializable {
		[Serialize("use"         )] public bool use;
		[Serialize("centerOffset")] public Vector2 centerOffset;
		[Serialize("strength"    )] public float strength;
		[Serialize("size"        )] public float size;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(centerOffset));
			SerializeField(s, nameof(strength));
			SerializeField(s, nameof(size));
		}
	}
}

