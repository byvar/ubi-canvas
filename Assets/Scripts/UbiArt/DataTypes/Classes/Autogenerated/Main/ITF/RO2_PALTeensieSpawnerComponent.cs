namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PALTeensieSpawnerComponent : ActorComponent {
		public float raycastLength;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			raycastLength = s.Serialize<float>(raycastLength, name: "raycastLength");
		}
		public override uint? ClassCRC => 0x0C9783AF;
	}
}

