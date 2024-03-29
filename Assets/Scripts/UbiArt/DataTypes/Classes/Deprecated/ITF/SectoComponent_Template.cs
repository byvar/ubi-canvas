namespace UbiArt.ITF {
	[Games(GameFlags.RL, platforms: PlatformFlags.Vita)] // Only on Vita!
	public partial class SectoComponent_Template : ActorComponent_Template {
		public uint Vita_00 { get; set; }
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
		}
		public override uint? ClassCRC => 0x581AAC2E;
	}
}
