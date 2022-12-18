namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_PhialBTComponent : ActorComponent {
		public EditableShape shape;
		public bool detectDangerousGround;
		public int broken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				shape = s.SerializeObject<EditableShape>(shape, name: "shape");
				detectDangerousGround = s.Serialize<bool>(detectDangerousGround, name: "detectDangerousGround", options: CSerializerObject.Options.BoolAsByte);
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				broken = s.Serialize<int>(broken, name: "broken");
			}
		}
		public override uint? ClassCRC => 0x0A7203EA;
	}
}

