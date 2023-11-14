namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SnakeBodyPartSpriteRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		public AnimationAtlas anim;
		public AABB drawAABB = new AABB() { MIN = new Vec2d(-1, -1), MAX = new Vec2d(0.5f, 0) };
		public Color color = Color.White;
		public CListO<Vec2d> polyline;
		public CListO<Vec2d> otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<AnimationAtlas>(anim, name: "anim");
			drawAABB = s.SerializeObject<AABB>(drawAABB, name: "drawAABB");
			color = s.SerializeObject<Color>(color, name: "color");
			polyline = s.SerializeObject<CListO<Vec2d>>(polyline, name: "polyline");
			otherPolyline = s.SerializeObject<CListO<Vec2d>>(otherPolyline, name: "otherPolyline");
		}
		public override uint? ClassCRC => 0x56D9502D;
	}
}

