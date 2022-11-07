namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AILumsComponent : ActorComponent {
		public bool IsTaken;
		public Color initColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				IsTaken = s.Serialize<bool>(IsTaken, name: "IsTaken");
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				initColor = s.Serialize<Color>(initColor, name: "initColor");
			}
		}
		public enum Color {
			[Serialize("Color_Yellow")] Yellow = 0,
			[Serialize("Color_Purple")] Purple = 1,
		}
		public override uint? ClassCRC => 0x8519D5E8;
	}
}

