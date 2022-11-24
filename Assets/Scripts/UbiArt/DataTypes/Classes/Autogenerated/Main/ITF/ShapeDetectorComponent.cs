namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ShapeDetectorComponent : DetectorComponent {
		public Vec2d localOffset;
		public Vec2d localScale = Vec2d.One;
		public bool useShapeTransform = true;
		public bool useEditableShape;
		public EditableShape editableShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR) {
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					localScale = s.SerializeObject<Vec2d>(localScale, name: "localScale");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					useShapeTransform = s.Serialize<bool>(useShapeTransform, name: "useShapeTransform");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					localScale = s.SerializeObject<Vec2d>(localScale, name: "localScale");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					useShapeTransform = s.Serialize<bool>(useShapeTransform, name: "useShapeTransform");
				}
				useEditableShape = s.Serialize<bool>(useEditableShape, name: "useEditableShape");
				editableShape = s.SerializeObject<EditableShape>(editableShape, name: "editableShape");
			}
		}
		public override uint? ClassCRC => 0x6DD3B10F;
	}
}

