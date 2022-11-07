namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class SectoTriggerComponent : ActorComponent {
		public uint uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
		}
		public override uint? ClassCRC => 0x6231C40B;
	}
}

