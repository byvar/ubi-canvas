namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class PhysForceModifierPolygon_Template : PhysForceModifier_Template {
		public PhysShapePolygon polygon;
		public Vec2d direction;
		public Vec2d centre;
		public float fallOffStart;
		public float fallOffEnd;
		public float gradientStart;
		public float gradientEnd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
			} else if (s.Settings.game == Settings.Game.COL) {
				gradientStart = s.Serialize<float>(gradientStart, name: "gradientStart");
				gradientEnd = s.Serialize<float>(gradientEnd, name: "gradientEnd");
			} else {
				polygon = s.SerializeObject<PhysShapePolygon>(polygon, name: "polygon");
				direction = s.SerializeObject<Vec2d>(direction, name: "direction");
				centre = s.SerializeObject<Vec2d>(centre, name: "centre");
				fallOffStart = s.Serialize<float>(fallOffStart, name: "fallOffStart");
				fallOffEnd = s.Serialize<float>(fallOffEnd, name: "fallOffEnd");
			}
		}
		public override uint? ClassCRC => 0xFE78AAD8;
	}
}

