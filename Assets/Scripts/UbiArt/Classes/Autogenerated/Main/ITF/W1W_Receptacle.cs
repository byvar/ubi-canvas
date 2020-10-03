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
		public CArrayO<W1W_ItemType> CArray_W1W_ItemType__9;
		public CArrayO<W1W_ItemType> CArray_W1W_ItemType__10;
		public CArrayO<EventSender> CArray_EventSender__11;
		public CArrayO<EventSender> CArray_EventSender__12;
		public CArrayO<EventSender> CArray_EventSender__13;
		public CArrayO<EventSender> CArray_EventSender__14;
		public CArrayO<EventSender> CArray_EventSender__15;
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
				StringID__1_ = s.SerializeObject<StringID>(StringID__1_, name: "StringID__1");
				bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
				bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
				bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
				bool__8_ = s.Serialize<bool>(bool__8_, name: "bool__8");
				CArray_W1W_ItemType__9 = s.SerializeObject<CArrayO<W1W_ItemType>>(CArray_W1W_ItemType__9, name: "CArray<W1W_ItemType>__9");
				CArray_W1W_ItemType__10 = s.SerializeObject<CArrayO<W1W_ItemType>>(CArray_W1W_ItemType__10, name: "CArray<W1W_ItemType>__10");
				CArray_EventSender__11 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__11, name: "CArray<EventSender>__11");
				CArray_EventSender__12 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__12, name: "CArray<EventSender>__12");
				CArray_EventSender__13 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__13, name: "CArray<EventSender>__13");
				CArray_EventSender__14 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__14, name: "CArray<EventSender>__14");
				CArray_EventSender__15 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__15, name: "CArray<EventSender>__15");
				bool__16_ = s.Serialize<bool>(bool__16_, name: "bool__16");
				EventSender__17 = s.SerializeObject<EventSender>(EventSender__17, name: "EventSender__17");
				bool__18_ = s.Serialize<bool>(bool__18_, name: "bool__18");
				bool__19_ = s.Serialize<bool>(bool__19_, name: "bool__19");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
			}
			Path__20 = s.SerializeObject<Path>(Path__20, name: "Path__20");
			bool__21 = s.Serialize<bool>(bool__21, name: "bool__21");
		}
		public override uint? ClassCRC => 0x1E080554;
	}
}

