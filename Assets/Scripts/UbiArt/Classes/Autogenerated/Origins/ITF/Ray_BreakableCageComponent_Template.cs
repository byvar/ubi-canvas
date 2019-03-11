using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BreakableCageComponent_Template : CSerializable {
		[Serialize("stage1Anim"        )] public StringID stage1Anim;
		[Serialize("stage2Anim"        )] public StringID stage2Anim;
		[Serialize("stage3Anim"        )] public StringID stage3Anim;
		[Serialize("stage1toStage2Anim")] public StringID stage1toStage2Anim;
		[Serialize("stage2toStage3Anim")] public StringID stage2toStage3Anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stage1Anim));
			SerializeField(s, nameof(stage2Anim));
			SerializeField(s, nameof(stage3Anim));
			SerializeField(s, nameof(stage1toStage2Anim));
			SerializeField(s, nameof(stage2toStage3Anim));
		}
		public override uint? ClassCRC => 0x8D9BEDBC;
	}
}

