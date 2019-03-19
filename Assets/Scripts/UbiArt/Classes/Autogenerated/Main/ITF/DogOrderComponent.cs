using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class DogOrderComponent : ActorComponent {
		[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("StringID__1" )] public StringID StringID__1;
		[Serialize("bool__2"     )] public bool bool__2;
		[Serialize("bool__3"     )] public bool bool__3;
		[Serialize("float__4"    )] public float float__4;
		[Serialize("bool__5"     )] public bool bool__5;
		[Serialize("Enum_VH_1__6")] public Enum_VH_1 Enum_VH_1__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(bool__5));
			SerializeField(s, nameof(Enum_VH_1__6));
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_9")] Value_9 = 9,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x291C40BE;
	}
}

