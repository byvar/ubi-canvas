namespace UbiArt.ITF {
	[Games(GameFlags.RL, platforms: PlatformFlags.Vita)] // Only on Vita!
	public partial class ColorComponent_Template : ActorComponent_Template {
		public float float8;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float8 = s.Serialize<float>(float8, name: nameof(float8));
		}
		public override uint? ClassCRC => 0xC3173B7D;
	}
}
