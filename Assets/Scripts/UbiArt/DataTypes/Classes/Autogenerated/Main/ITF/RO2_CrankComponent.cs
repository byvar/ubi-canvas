namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CrankComponent : ActorComponent {
		public Vec2d controlOffset = Vec2d.Down;
		public Vec2d textPos = new Vec2d(640, 620);
		public EditableShape shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				controlOffset = s.SerializeObject<Vec2d>(controlOffset, name: "controlOffset");
				textPos = s.SerializeObject<Vec2d>(textPos, name: "textPos");
				shape = s.SerializeObject<EditableShape>(shape, name: "shape");
			}
		}
		public override uint? ClassCRC => 0x100FB3FF;
	}
}

