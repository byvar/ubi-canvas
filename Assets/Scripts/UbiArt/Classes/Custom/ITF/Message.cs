using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Message : CSerializable {
		[Serialize("message_handle"     )] public uint message_handle;
		[Serialize("type"               )] public uint type;
		[Serialize("onlinedate"         )] public online.DateTime onlinedate;
		[Serialize("localDate"          )] public online.DateTime localDate;
		[Serialize("persistentSeconds"  )] public uint persistentSeconds;
		[Serialize("title"              )] public SmartLocId title;
		[Serialize("body"               )] public SmartLocId body;
		[Serialize("isPrompt"           )] public bool isPrompt;
		[Serialize("isDrc"              )] public bool isDrc;
		[Serialize("hasBeenRead"        )] public bool hasBeenRead;
		[Serialize("isOnline"           )] public bool isOnline;
		[Serialize("removeAfterRead"    )] public bool removeAfterRead;
		[Serialize("hasBeenInteract"    )] public bool hasBeenInteract;
		[Serialize("removeAfterInteract")] public bool removeAfterInteract;
		[Serialize("lockedAfterInteract")] public bool lockedAfterInteract;
		[Serialize("buttons"            )] public CList<SmartLocId> buttons;
		[Serialize("attributes"         )] public CList<Attribute> attributes;
		[Serialize("markers"            )] public CList<Marker> markers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(message_handle));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(onlinedate));
				SerializeField(s, nameof(localDate));
				SerializeField(s, nameof(persistentSeconds));
				SerializeField(s, nameof(title));
				SerializeField(s, nameof(body));
				SerializeField(s, nameof(isPrompt), boolAsByte: true);
				SerializeField(s, nameof(isDrc), boolAsByte: true);
				SerializeField(s, nameof(hasBeenRead), boolAsByte: true);
				SerializeField(s, nameof(isOnline), boolAsByte: true);
				SerializeField(s, nameof(removeAfterRead), boolAsByte: true);
				SerializeField(s, nameof(hasBeenInteract), boolAsByte: true);
				SerializeField(s, nameof(removeAfterInteract), boolAsByte: true);
				SerializeField(s, nameof(lockedAfterInteract), boolAsByte: true);
				SerializeField(s, nameof(buttons));
				SerializeField(s, nameof(attributes));
				SerializeField(s, nameof(markers));
			}
		}

		[Games(GameFlags.RL)]
		public partial class Marker : CSerializable {
			[Serialize("locId"   )] public SmartLocId locId;
			[Serialize("color"   )] public uint color;
			[Serialize("fontSize")] public float fontSize;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(locId));
					SerializeField(s, nameof(color));
					SerializeField(s, nameof(fontSize));
				}
			}
		}

		[Games(GameFlags.RL)]
		public partial class Attribute : CSerializable {
			[Serialize("type" )] public uint type;
			[Serialize("value")] public uint value;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(type));
					SerializeField(s, nameof(value));
				}
			}
		}
	}
}