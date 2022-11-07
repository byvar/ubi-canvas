namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DummyAIReceiveHitBehavior_Template : CSerializable {
		public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
		}
		public override uint? ClassCRC => 0x3676A869;
	}
}

