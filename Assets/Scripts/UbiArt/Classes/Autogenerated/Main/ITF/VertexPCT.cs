using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class VertexPCT : CSerializable {
		[Serialize("pos"  )] public Vec3d pos;
		[Serialize("color")] public ColorInteger color;
		[Serialize("uv"   )] public Vec2d uv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(uv));
		}
	}
}

