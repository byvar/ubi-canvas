namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SnakeBodyPartSpriteRenderer_Template : RO2_SnakeBodyPartRenderer_Template {
		public AnimationAtlas anim;
		public AABB drawAABB = new AABB() { MIN = new Vec2d(-1, -1), MAX = new Vec2d(0.5f, 0) };
		public Color color = Color.White;
		public Placeholder polyline;
		public Placeholder otherPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				anim = s.SerializeObject<AnimationAtlas>(anim, name: "anim");
				drawAABB = s.SerializeObject<AABB>(drawAABB, name: "drawAABB");
				color = s.SerializeObject<Color>(color, name: "color");
				polyline = s.SerializeObject<Placeholder>(polyline, name: "polyline");
				otherPolyline = s.SerializeObject<Placeholder>(otherPolyline, name: "otherPolyline");
			} else {
				anim = s.SerializeObject<AnimationAtlas>(anim, name: "anim");
				drawAABB = s.SerializeObject<AABB>(drawAABB, name: "drawAABB");
				color = s.SerializeObject<Color>(color, name: "color");
			}
		}
		public override uint? ClassCRC => 0x56D9502D;
	}
}

