using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Receptacle : W1W_InteractiveGenComponent {
		[Serialize("StringID__0"             )] public StringID StringID__0;
		[Serialize("StringID__1"             )] public StringID StringID__1_;
		[Serialize("bool__2"                 )] public bool bool__2;
		[Serialize("Vector2__3"              )] public Vec2d Vector2__3;
		[Serialize("float__4"                )] public float float__4;
		[Serialize("bool__5"                 )] public bool bool__5;
		[Serialize("bool__6"                 )] public bool bool__6;
		[Serialize("bool__7"                 )] public bool bool__7;
		[Serialize("bool__8"                 )] public bool bool__8_;
		[Serialize("CArray<W1W_ItemType>__9" )] public CArray<W1W_ItemType> CArray_W1W_ItemType__9;
		[Serialize("CArray<W1W_ItemType>__10")] public CArray<W1W_ItemType> CArray_W1W_ItemType__10;
		[Serialize("CArray<EventSender>__11" )] public CArray<EventSender> CArray_EventSender__11;
		[Serialize("CArray<EventSender>__12" )] public CArray<EventSender> CArray_EventSender__12;
		[Serialize("CArray<EventSender>__13" )] public CArray<EventSender> CArray_EventSender__13;
		[Serialize("CArray<EventSender>__14" )] public CArray<EventSender> CArray_EventSender__14;
		[Serialize("CArray<EventSender>__15" )] public CArray<EventSender> CArray_EventSender__15;
		[Serialize("bool__16"                )] public bool bool__16_;
		[Serialize("EventSender__17"         )] public EventSender EventSender__17;
		[Serialize("bool__18"                )] public bool bool__18_;
		[Serialize("bool__19"                )] public bool bool__19_;
		[Serialize("Path__20"                )] public Path Path__20;
		[Serialize("bool__21"                )] public bool bool__21;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1_));
				SerializeField(s, nameof(bool__2));
				SerializeField(s, nameof(Vector2__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(bool__8_));
				SerializeField(s, nameof(CArray_W1W_ItemType__9));
				SerializeField(s, nameof(CArray_W1W_ItemType__10));
				SerializeField(s, nameof(CArray_EventSender__11));
				SerializeField(s, nameof(CArray_EventSender__12));
				SerializeField(s, nameof(CArray_EventSender__13));
				SerializeField(s, nameof(CArray_EventSender__14));
				SerializeField(s, nameof(CArray_EventSender__15));
				SerializeField(s, nameof(bool__16_));
				SerializeField(s, nameof(EventSender__17));
				SerializeField(s, nameof(bool__18_));
				SerializeField(s, nameof(bool__19_));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
			}
			SerializeField(s, nameof(Path__20));
			SerializeField(s, nameof(bool__21));
		}
		public override uint? ClassCRC => 0x1E080554;
	}
}

