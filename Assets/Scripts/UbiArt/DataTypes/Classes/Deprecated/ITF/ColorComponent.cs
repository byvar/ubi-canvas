namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // Only on Vita!
	public partial class ColorComponent : ActorComponent {
		public Color float3;
		public Color float7;
		public float float8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float3 = s.SerializeObject<Color>(float3, name: nameof(float3));
			float7 = s.SerializeObject<Color>(float7, name: nameof(float7));
			float8 = s.Serialize<float>(float8, name: nameof(float8));
		}
		public override uint? ClassCRC => 0x7EB87D5E;
	}
}
