using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Message : CSerializable {
		public uint message_handle;
		public uint type;
		public online.DateTime onlinedate;
		public online.DateTime localDate;
		public uint persistentSeconds;
		public SmartLocId title;
		public SmartLocId body;
		public bool isPrompt;
		public bool isDrc;
		public bool hasBeenRead;
		public bool isOnline;
		public bool removeAfterRead;
		public bool hasBeenInteract;
		public bool removeAfterInteract;
		public bool lockedAfterInteract;
		public CList<SmartLocId> buttons;
		public CList<Attribute> attributes;
		public CList<Marker> markers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				message_handle = s.Serialize<uint>(message_handle, name: "message_handle");
				type = s.Serialize<uint>(type, name: "type");
				onlinedate = s.SerializeObject<online.DateTime>(onlinedate, name: "onlinedate");
				localDate = s.SerializeObject<online.DateTime>(localDate, name: "localDate");
				persistentSeconds = s.Serialize<uint>(persistentSeconds, name: "persistentSeconds");
				title = s.SerializeObject<SmartLocId>(title, name: "title");
				body = s.SerializeObject<SmartLocId>(body, name: "body");
				isPrompt = s.Serialize<bool>(isPrompt, name: "isPrompt", options: CSerializerObject.Options.BoolAsByte);
				isDrc = s.Serialize<bool>(isDrc, name: "isDrc", options: CSerializerObject.Options.BoolAsByte);
				hasBeenRead = s.Serialize<bool>(hasBeenRead, name: "hasBeenRead", options: CSerializerObject.Options.BoolAsByte);
				isOnline = s.Serialize<bool>(isOnline, name: "isOnline", options: CSerializerObject.Options.BoolAsByte);
				removeAfterRead = s.Serialize<bool>(removeAfterRead, name: "removeAfterRead", options: CSerializerObject.Options.BoolAsByte);
				hasBeenInteract = s.Serialize<bool>(hasBeenInteract, name: "hasBeenInteract", options: CSerializerObject.Options.BoolAsByte);
				removeAfterInteract = s.Serialize<bool>(removeAfterInteract, name: "removeAfterInteract", options: CSerializerObject.Options.BoolAsByte);
				lockedAfterInteract = s.Serialize<bool>(lockedAfterInteract, name: "lockedAfterInteract", options: CSerializerObject.Options.BoolAsByte);
				buttons = s.SerializeObject<CList<SmartLocId>>(buttons, name: "buttons");
				attributes = s.SerializeObject<CList<Attribute>>(attributes, name: "attributes");
				markers = s.SerializeObject<CList<Marker>>(markers, name: "markers");
			}
		}

		[Games(GameFlags.RL)]
		public partial class Marker : CSerializable {
			public SmartLocId locId;
			public uint color;
			public float fontSize;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					locId = s.SerializeObject<SmartLocId>(locId, name: "locId");
					color = s.Serialize<uint>(color, name: "color");
					fontSize = s.Serialize<float>(fontSize, name: "fontSize");
				}
			}
		}

		[Games(GameFlags.RL)]
		public partial class Attribute : CSerializable {
			public uint type;
			public uint value;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					type = s.Serialize<uint>(type, name: "type");
					value = s.Serialize<uint>(value, name: "value");
				}
			}
		}
	}
}
