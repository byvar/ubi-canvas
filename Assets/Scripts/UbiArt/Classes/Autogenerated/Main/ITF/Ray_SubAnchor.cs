using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SubAnchor : CSerializable {
		[Serialize("name")] public StringID name;
		[Serialize("pos" )] public Vec3d pos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(pos));
		}
	}
}

