using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_215_sub_7E8750 : ActorComponent_Template {
		[Serialize("fxName"       )] public StringID fxName;
		[Serialize("autoUpdatePos")] public int autoUpdatePos;
		[Serialize("scaleFXGrab"  )] public Vec2d scaleFXGrab;
		[Serialize("offsetFXGrab" )] public Vec2d offsetFXGrab;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fxName));
			SerializeField(s, nameof(autoUpdatePos));
			SerializeField(s, nameof(scaleFXGrab));
			SerializeField(s, nameof(offsetFXGrab));
		}
		public override uint? ClassCRC => 0xAF05B0CD;
	}
}

