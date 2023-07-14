namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // Only on Vita!
	public partial class DynamicLightZoneComponent_Template : ActorComponent_Template {
		public uint Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
		}
		public override uint? ClassCRC => 0xB8AFB5C9;
	}
}
