using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Helmut_Template : Npc_Template {
		public WithAnimStateMachine_Template WithAnimStateMachine_Template__0;
		public float float__1_;
		public float float__2_;
		public float float__3_;
		public float float__4_;
		public float float__5_;
		public float float__6_;
		public float float__7;
		public float float__8;
		public float float__9;
		public Vec2d Vector2__10;
		public float float__11;
		public float float__12;
		public float float__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WithAnimStateMachine_Template__0 = s.SerializeObject<WithAnimStateMachine_Template>(WithAnimStateMachine_Template__0, name: "WithAnimStateMachine_Template__0");
			float__1_ = s.Serialize<float>(float__1_, name: "float__1");
			float__2_ = s.Serialize<float>(float__2_, name: "float__2");
			float__3_ = s.Serialize<float>(float__3_, name: "float__3");
			float__4_ = s.Serialize<float>(float__4_, name: "float__4");
			float__5_ = s.Serialize<float>(float__5_, name: "float__5");
			float__6_ = s.Serialize<float>(float__6_, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			Vector2__10 = s.SerializeObject<Vec2d>(Vector2__10, name: "Vector2__10");
			float__11 = s.Serialize<float>(float__11, name: "float__11");
			float__12 = s.Serialize<float>(float__12, name: "float__12");
			float__13 = s.Serialize<float>(float__13, name: "float__13");
		}
		public override uint? ClassCRC => 0xA76C965E;
	}
}

