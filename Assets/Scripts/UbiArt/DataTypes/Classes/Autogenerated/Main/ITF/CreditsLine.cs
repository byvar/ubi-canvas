namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class CreditsLine : CSerializable {
		public uint type;
		public uint flag;
		public string text;
		public string firstName;
		public string lastName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<uint>(type, name: "type");
			flag = s.Serialize<uint>(flag, name: "flag");
			text = s.Serialize<string>(text, name: "text");
			firstName = s.Serialize<string>(firstName, name: "firstName");
			lastName = s.Serialize<string>(lastName, name: "lastName");
		}
	}
}

