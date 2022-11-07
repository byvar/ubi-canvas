namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CrankComponent : ActorComponent {
		public Vec2d controlOffset;
		public Vec2d textPos;
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

