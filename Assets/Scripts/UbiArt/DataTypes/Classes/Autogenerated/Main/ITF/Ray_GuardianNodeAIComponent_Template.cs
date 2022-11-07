namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Ray_GuardianNodeAIComponent_Template : CSerializable {
		public int int__0;
		public uint uint__1;
		public float float__2;
		public float float__3;
		public Vec2d Vector2__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			float__10 = s.Serialize<float>(float__10, name: "float__10");
		}
		public override uint? ClassCRC => 0x629D749F;
	}
}

