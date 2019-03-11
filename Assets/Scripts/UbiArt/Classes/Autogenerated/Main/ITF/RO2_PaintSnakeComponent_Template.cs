using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PaintSnakeComponent_Template : ActorComponent_Template {
		[Serialize("BubonBoneL"       )] public StringID BubonBoneL;
		[Serialize("BubonBoneR"       )] public StringID BubonBoneR;
		[Serialize("RadiusTouchScreen")] public float RadiusTouchScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(BubonBoneL));
			SerializeField(s, nameof(BubonBoneR));
			SerializeField(s, nameof(RadiusTouchScreen));
		}
		public override uint? ClassCRC => 0xC89B8AA0;
	}
}

