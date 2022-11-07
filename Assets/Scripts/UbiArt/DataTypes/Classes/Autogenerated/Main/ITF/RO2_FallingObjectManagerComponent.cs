namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_FallingObjectManagerComponent : ActorComponent {
		public float distance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				distance = s.Serialize<float>(distance, name: "distance");
			}
		}
		public override uint? ClassCRC => 0xF321B497;
	}
}

