namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BubbleSpawnerComponent : ActorComponent {
		public float bubbleLifetime;
		public float bubbleFloatForceX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bubbleLifetime = s.Serialize<float>(bubbleLifetime, name: "bubbleLifetime");
				bubbleFloatForceX = s.Serialize<float>(bubbleFloatForceX, name: "bubbleFloatForceX");
			}
		}
		public override uint? ClassCRC => 0xF43E36BB;
	}
}

