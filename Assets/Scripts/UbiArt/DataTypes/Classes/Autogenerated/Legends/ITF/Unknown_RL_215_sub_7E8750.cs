using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_215_sub_7E8750 : ActorComponent_Template {
		public StringID fxName;
		public int autoUpdatePos;
		public Vec2d scaleFXGrab;
		public Vec2d offsetFXGrab;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fxName = s.SerializeObject<StringID>(fxName, name: "fxName");
			autoUpdatePos = s.Serialize<int>(autoUpdatePos, name: "autoUpdatePos");
			scaleFXGrab = s.SerializeObject<Vec2d>(scaleFXGrab, name: "scaleFXGrab");
			offsetFXGrab = s.SerializeObject<Vec2d>(offsetFXGrab, name: "offsetFXGrab");
		}
		public override uint? ClassCRC => 0xAF05B0CD;
	}
}

