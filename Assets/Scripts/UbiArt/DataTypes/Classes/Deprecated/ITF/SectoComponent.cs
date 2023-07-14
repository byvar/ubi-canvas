namespace UbiArt.ITF {
	[Games(GameFlags.RL, platforms: PlatformFlags.Vita)] // Only on Vita!
	public partial class SectoComponent : ActorComponent {
		public uint UInt_00 { get; set; }
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			UInt_00 = s.Serialize<uint>(UInt_00, name: nameof(UInt_00));
		}
		public override uint? ClassCRC => 0xB475B1E0;
	}
}
