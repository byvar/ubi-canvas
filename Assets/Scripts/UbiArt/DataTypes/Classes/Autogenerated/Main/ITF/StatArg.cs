namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class StatArg : CSerializable {
		public string name;
		public StatValue value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.Serialize<string>(name, name: "name");
			value = s.SerializeObject<StatValue>(value, name: "value");
		}
	}
}

