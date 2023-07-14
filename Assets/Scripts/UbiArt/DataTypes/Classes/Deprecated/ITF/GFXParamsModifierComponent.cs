namespace UbiArt.ITF {
	[Games(GameFlags.RL, platforms: PlatformFlags.Vita)] // Only on Vita!
	public partial class GFXParamsModifierComponent : ActorComponent {
		public Color float3;
		public Color float7;
		public float float8;
		public byte byte9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float3 = s.SerializeObject<Color>(float3, name: nameof(float3));
			float7 = s.SerializeObject<Color>(float7, name: nameof(float7));
			float8 = s.Serialize<float>(float8, name: nameof(float8));
			byte9 = s.Serialize<byte>(byte9, name: nameof(byte9));
		}
		public override uint? ClassCRC => 0x28097124;
	}
}
