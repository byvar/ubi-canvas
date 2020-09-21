using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class BodyPartSpriteRenderer_Template : CSerializable {
		public AnimationAtlas AnimationAtlas__0;
		public AABB AABB__1;
		public Color Color__2;
		public CArrayO<Vec2d> CArray_Vector2__3;
		public CArrayO<Vec2d> CArray_Vector2__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AnimationAtlas__0 = s.SerializeObject<AnimationAtlas>(AnimationAtlas__0, name: "AnimationAtlas__0");
			AABB__1 = s.SerializeObject<AABB>(AABB__1, name: "AABB__1");
			Color__2 = s.SerializeObject<Color>(Color__2, name: "Color__2");
			CArray_Vector2__3 = s.SerializeObject<CArrayO<Vec2d>>(CArray_Vector2__3, name: "CArray_Vector2__3");
			CArray_Vector2__4 = s.SerializeObject<CArrayO<Vec2d>>(CArray_Vector2__4, name: "CArray_Vector2__4");
		}
	}
}

