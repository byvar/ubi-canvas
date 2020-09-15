using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class BodyPartSpriteRenderer_Template : CSerializable {
		[Serialize("AnimationAtlas__0" )] public AnimationAtlas AnimationAtlas__0;
		[Serialize("AABB__1"           )] public AABB AABB__1;
		[Serialize("Color__2"          )] public Color Color__2;
		[Serialize("CArray<Vector2>__3")] public CArray<Vec2d> CArray_Vector2__3;
		[Serialize("CArray<Vector2>__4")] public CArray<Vec2d> CArray_Vector2__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(AnimationAtlas__0));
			SerializeField(s, nameof(AABB__1));
			SerializeField(s, nameof(Color__2));
			SerializeField(s, nameof(CArray_Vector2__3));
			SerializeField(s, nameof(CArray_Vector2__4));
		}
	}
}

