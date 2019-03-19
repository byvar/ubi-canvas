using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class TestSpriteData : CSerializable {
		[Serialize("StringID__0"              )] public StringID StringID__0;
		[Serialize("float__1"                 )] public float float__1;
		[Serialize("float__2"                 )] public float float__2;
		[Serialize("bool__3"                  )] public bool bool__3;
		[Serialize("CArray<TestSpriteBone>__4")] public CArray<TestSpriteBone> CArray_TestSpriteBone__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(CArray_TestSpriteBone__4));
		}
	}
}

