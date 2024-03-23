namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PolygonWindComponent : PhysForceModifierComponent {
		public PhysForceModifier_Template forceModifier;
		public CListO<Vec2d> point;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			forceModifier = s.SerializeObject<PhysForceModifier_Template>(forceModifier, name: "forceModifier");
			point = s.SerializeObject<CListO<Vec2d>>(point, name: "point");
		}
		public override uint? ClassCRC => 0xEEC96D29;
	}
}

