using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class RO2_DigRegionComponent_Template : ActorComponent_Template {
		[Serialize("GFXMaterialSerializable__0")] public GFXMaterialSerializable GFXMaterialSerializable__0;
		[Serialize("GFXMaterialSerializable__1")] public GFXMaterialSerializable GFXMaterialSerializable__1;
		[Serialize("GFXMaterialSerializable__2")] public GFXMaterialSerializable GFXMaterialSerializable__2;
		[Serialize("float__3"                  )] public float float__3;
		[Serialize("float__4"                  )] public float float__4;
		[Serialize("float__5"                  )] public float float__5;
		[Serialize("float__6"                  )] public float float__6;
		[Serialize("GFXMaterialSerializable__7")] public GFXMaterialSerializable GFXMaterialSerializable__7;
		[Serialize("GFXMaterialSerializable__8")] public GFXMaterialSerializable GFXMaterialSerializable__8;
		[Serialize("GFXMaterialSerializable__9")] public GFXMaterialSerializable GFXMaterialSerializable__9;
		[Serialize("Path__10"                  )] public Path Path__10;
		[Serialize("StringID__11"              )] public StringID StringID__11;
		[Serialize("StringID__12"              )] public StringID StringID__12;
		[Serialize("StringID__13"              )] public StringID StringID__13;
		[Serialize("StringID__14"              )] public StringID StringID__14;
		[Serialize("float__15"                 )] public float float__15;
		[Serialize("StringID__16"              )] public StringID StringID__16;
		[Serialize("float__17"                 )] public float float__17;
		[Serialize("StringID__18"              )] public StringID StringID__18;
		[Serialize("StringID__19"              )] public StringID StringID__19;
		[Serialize("Border__20"                )] public Border Border__20;
		[Serialize("bool__21"                  )] public bool bool__21;
		[Serialize("bool__22"                  )] public bool bool__22;
		[Serialize("float__23"                 )] public float float__23;
		[Serialize("float__24"                 )] public float float__24;
		[Serialize("uint__25"                  )] public uint uint__25;
		[Serialize("Vector2__26"               )] public Vector2 Vector2__26;
		[Serialize("float__27"                 )] public float float__27;
		[Serialize("float__28"                 )] public float float__28;
		[Serialize("uint__29"                  )] public uint uint__29;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(GFXMaterialSerializable__0));
				SerializeField(s, nameof(GFXMaterialSerializable__1));
				SerializeField(s, nameof(GFXMaterialSerializable__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
			}
			SerializeField(s, nameof(GFXMaterialSerializable__7));
			SerializeField(s, nameof(GFXMaterialSerializable__8));
			SerializeField(s, nameof(GFXMaterialSerializable__9));
			SerializeField(s, nameof(Path__10));
			SerializeField(s, nameof(StringID__11));
			SerializeField(s, nameof(StringID__12));
			SerializeField(s, nameof(StringID__13));
			SerializeField(s, nameof(StringID__14));
			SerializeField(s, nameof(float__15));
			SerializeField(s, nameof(StringID__16));
			SerializeField(s, nameof(float__17));
			SerializeField(s, nameof(StringID__18));
			SerializeField(s, nameof(StringID__19));
			SerializeField(s, nameof(Border__20));
			SerializeField(s, nameof(bool__21));
			SerializeField(s, nameof(bool__22));
			SerializeField(s, nameof(float__23));
			SerializeField(s, nameof(float__24));
			SerializeField(s, nameof(uint__25));
			SerializeField(s, nameof(Vector2__26));
			SerializeField(s, nameof(float__27));
			SerializeField(s, nameof(float__28));
			SerializeField(s, nameof(uint__29));
		}
		public override uint? ClassCRC => 0xC495DF1B;
	}
}

