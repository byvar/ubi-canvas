namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class QuoteCondition : CSerializable {
		public StringID Type;
		public uint Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Type = s.SerializeObject<StringID>(Type, name: "Type");
			Value = s.Serialize<uint>(Value, name: "Value");
		}
	}
}

