namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class PhoenixCheckpointComponent_Template : ActorComponent_Template {
		public StringID StringID__0;
		public StringID StringID__1;
		public StringID StringID__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
		}
		public override uint? ClassCRC => 0x61104501;
	}
}

