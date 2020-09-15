using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TestSpriteBone : CSerializable {
		[Serialize("name")] public StringID name;
		[Serialize("p0"  )] public Vec2d p0;
		[Serialize("p1"  )] public Vec2d p1;
		[Serialize("uv0" )] public Vec2d uv0;
		[Serialize("uv1" )] public Vec2d uv1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(p0));
			SerializeField(s, nameof(p1));
			SerializeField(s, nameof(uv0));
			SerializeField(s, nameof(uv1));
		}
	}
}

