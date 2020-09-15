using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Receptacle : W1W_InteractiveGenComponent {
		public StringID StringID__0;
		public StringID StringID__1_;
		public bool bool__2;
		public Vec2d Vector2__3;
		public float float__4;
		public bool bool__5;
		public bool bool__6;
		public bool bool__7;
		public bool bool__8_;
		public CArray<W1W_ItemType> CArray_W1W_ItemType__9;
		public CArray<W1W_ItemType> CArray_W1W_ItemType__10;
		public CArray<EventSender> CArray_EventSender__11;
		public CArray<EventSender> CArray_EventSender__12;
		public CArray<EventSender> CArray_EventSender__13;
		public CArray<EventSender> CArray_EventSender__14;
		public CArray<EventSender> CArray_EventSender__15;
		public bool bool__16_;
		public EventSender EventSender__17;
		public bool bool__18_;
		public bool bool__19_;
		public Path Path__20;
		public bool bool__21;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1_ = s.SerializeObject<StringID>(StringID__1_, name: "StringID__1_");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
				bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
				bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
				bool__8_ = s.Serialize<bool>(bool__8_, name: "bool__8_");
				CArray_W1W_ItemType__9 = s.SerializeObject<CArray<W1W_ItemType>>(CArray_W1W_ItemType__9, name: "CArray_W1W_ItemType__9");
				CArray_W1W_ItemType__10 = s.SerializeObject<CArray<W1W_ItemType>>(CArray_W1W_ItemType__10, name: "CArray_W1W_ItemType__10");
				CArray_EventSender__11 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__11, name: "CArray_EventSender__11");
				CArray_EventSender__12 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__12, name: "CArray_EventSender__12");
				CArray_EventSender__13 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__13, name: "CArray_EventSender__13");
				CArray_EventSender__14 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__14, name: "CArray_EventSender__14");
				CArray_EventSender__15 = s.SerializeObject<CArray<EventSender>>(CArray_EventSender__15, name: "CArray_EventSender__15");
				bool__16_ = s.Serialize<bool>(bool__16_, name: "bool__16_");
				EventSender__17 = s.SerializeObject<EventSender>(EventSender__17, name: "EventSender__17");
				bool__18_ = s.Serialize<bool>(bool__18_, name: "bool__18_");
				bool__19_ = s.Serialize<bool>(bool__19_, name: "bool__19_");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
			}
			Path__20 = s.SerializeObject<Path>(Path__20, name: "Path__20");
			bool__21 = s.Serialize<bool>(bool__21, name: "bool__21");
		}
		public override uint? ClassCRC => 0x1E080554;
	}
}

