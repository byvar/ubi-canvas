namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class BezierNode : CSerializable {
		public Vec3d pos;
		public Vec2d tangent;
		public float scale;
		public Nullable<BezierTween> tween;
		public float lumChainSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pos = s.SerializeObject<Vec3d>(pos, name: "pos");
			tangent = s.SerializeObject<Vec2d>(tangent, name: "tangent");
			scale = s.Serialize<float>(scale, name: "scale");
			tween = s.SerializeObject<Nullable<BezierTween>>(tween, name: "tween");
			if (s.Settings.Game != Game.COL) {
				lumChainSpeedMultiplier = s.Serialize<float>(lumChainSpeedMultiplier, name: "lumChainSpeedMultiplier");
			}
		}
	}
}

