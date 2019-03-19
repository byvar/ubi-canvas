using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TutoBubble : ActorComponent {
		[Serialize("Enum_VH_0__0"      )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("bool__1"           )] public bool bool__1;
		[Serialize("float__2"          )] public float float__2;
		[Serialize("float__3"          )] public float float__3;
		[Serialize("bool__4"           )] public bool bool__4;
		[Serialize("bool__5"           )] public bool bool__5;
		[Serialize("bool__6"           )] public bool bool__6;
		[Serialize("Vector2__7"        )] public Vector2 Vector2__7;
		[Serialize("Vector3__8"        )] public Vector3 Vector3__8;
		[Serialize("Vector3__9"        )] public Vector3 Vector3__9;
		[Serialize("bool__10"          )] public bool bool__10;
		[Serialize("Enum_VH_1__11"     )] public Enum_VH_1 Enum_VH_1__11;
		[Serialize("Generic<Event>__12")] public Generic<Event> Generic_Event__12;
		[Serialize("Generic<Event>__13")] public Generic<Event> Generic_Event__13;
		[Serialize("Generic<Event>__14")] public Generic<Event> Generic_Event__14;
		[Serialize("Generic<Event>__15")] public Generic<Event> Generic_Event__15;
		[Serialize("bool__16"          )] public bool bool__16;
		[Serialize("StringID__17"      )] public StringID StringID__17;
		[Serialize("StringID__18"      )] public StringID StringID__18;
		[Serialize("StringID__19"      )] public StringID StringID__19;
		[Serialize("StringID__20"      )] public StringID StringID__20;
		[Serialize("bool__21"          )] public bool bool__21;
		[Serialize("bool__22"          )] public bool bool__22;
		[Serialize("Margin__23"        )] public Margin Margin__23;
		[Serialize("float__24"         )] public float float__24;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(bool__4));
				SerializeField(s, nameof(bool__5));
				SerializeField(s, nameof(bool__6));
				SerializeField(s, nameof(Vector2__7));
				SerializeField(s, nameof(Vector3__8));
				SerializeField(s, nameof(Vector3__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(Enum_VH_1__11));
				SerializeField(s, nameof(Generic_Event__12));
				SerializeField(s, nameof(Generic_Event__13));
				SerializeField(s, nameof(Generic_Event__14));
				SerializeField(s, nameof(Generic_Event__15));
				SerializeField(s, nameof(bool__16));
				SerializeField(s, nameof(StringID__17));
				SerializeField(s, nameof(StringID__18));
				SerializeField(s, nameof(StringID__19));
				SerializeField(s, nameof(StringID__20));
				SerializeField(s, nameof(bool__21));
				SerializeField(s, nameof(bool__22));
				SerializeField(s, nameof(Margin__23));
				SerializeField(s, nameof(float__24));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xC019AF6A;
	}
}

