namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Message : CSerializable {
		public string message_id;
		public string from;
		public string to;
		public string message_type;
		public online.DateTime sentDate;
		public string title;
		public string text;
		public CMap<string, string> data;
		public CMap<Items.ItemType, int> items;
		public uint ttl;
		public bool force;
		public bool silent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			message_id = s.Serialize<string>(message_id, name: "message_id");
			from = s.Serialize<string>(from, name: "from");
			to = s.Serialize<string>(to, name: "to");
			message_type = s.Serialize<string>(message_type, name: "message_type");
			sentDate = s.SerializeObject<online.DateTime>(sentDate, name: "sentDate");
			title = s.Serialize<string>(title, name: "title");
			text = s.Serialize<string>(text, name: "text");
			data = s.SerializeObject<CMap<string, string>>(data, name: "data");
			items = s.SerializeObject<CMap<Items.ItemType, int>>(items, name: "items");
			ttl = s.Serialize<uint>(ttl, name: "ttl");
			force = s.Serialize<bool>(force, name: "force");
			silent = s.Serialize<bool>(silent, name: "silent");
		}
	}
}

