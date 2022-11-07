namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_FruitAIComponent : RO2_AIComponent {
		public float firstBounceDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			firstBounceDirection = s.Serialize<float>(firstBounceDirection, name: "firstBounceDirection");
		}
		public override uint? ClassCRC => 0x2FBC5781;
	}
}

