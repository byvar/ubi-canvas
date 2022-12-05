namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EditableShape : CSerializable {
		public Generic<PhysShape> shape;
		public StringID bindedBoneName;
		public Vec2d localOffset;
		public bool applyRotation = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
				if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
					bindedBoneName = s.SerializeObject<StringID>(bindedBoneName, name: "bindedBoneName");
					localOffset = s.SerializeObject<Vec2d>(localOffset, name: "localOffset");
					applyRotation = s.Serialize<bool>(applyRotation, name: "applyRotation");
				}
			}
		}
	}
}

