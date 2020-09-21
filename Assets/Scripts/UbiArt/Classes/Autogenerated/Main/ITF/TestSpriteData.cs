using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class TestSpriteData : CSerializable {
		public StringID StringID__0;
		public float float__1;
		public float float__2;
		public bool bool__3;
		public CArrayO<TestSpriteBone> CArray_TestSpriteBone__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			CArray_TestSpriteBone__4 = s.SerializeObject<CArrayO<TestSpriteBone>>(CArray_TestSpriteBone__4, name: "CArray_TestSpriteBone__4");
		}
	}
}

