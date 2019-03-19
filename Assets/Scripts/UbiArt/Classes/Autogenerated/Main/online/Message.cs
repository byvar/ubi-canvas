using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Message : CSerializable {
		[Serialize("message_id"  )] public string message_id;
		[Serialize("from"        )] public string from;
		[Serialize("to"          )] public string to;
		[Serialize("message_type")] public string message_type;
		[Serialize("sentDate"    )] public online.DateTime sentDate;
		[Serialize("title"       )] public string title;
		[Serialize("text"        )] public string text;
		[Serialize("data"        )] public CMap<string, string> data;
		[Serialize("items"       )] public CMap<Items.ItemType, int> items;
		[Serialize("ttl"         )] public uint ttl;
		[Serialize("force"       )] public bool force;
		[Serialize("silent"      )] public bool silent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(message_id));
			SerializeField(s, nameof(from));
			SerializeField(s, nameof(to));
			SerializeField(s, nameof(message_type));
			SerializeField(s, nameof(sentDate));
			SerializeField(s, nameof(title));
			SerializeField(s, nameof(text));
			SerializeField(s, nameof(data));
			SerializeField(s, nameof(items));
			SerializeField(s, nameof(ttl));
			SerializeField(s, nameof(force));
			SerializeField(s, nameof(silent));
		}
	}
}

