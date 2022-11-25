namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AIComponent : ActorComponent {
		public int health = 100;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				health = s.Serialize<int>(health, name: "health");
			}
		}
		public override uint? ClassCRC => 0xB83B5C61;
	}
}

