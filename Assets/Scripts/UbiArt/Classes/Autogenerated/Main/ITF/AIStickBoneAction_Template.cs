using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIStickBoneAction_Template : AIAction_Template {
		[Serialize("aiStickBoneName")] public StringID aiStickBoneName;
		[Serialize("aiStickBoneEnd" )] public bool aiStickBoneEnd;
		[Serialize("aiStickBoneTime")] public float aiStickBoneTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(aiStickBoneName));
			SerializeField(s, nameof(aiStickBoneEnd));
			SerializeField(s, nameof(aiStickBoneTime));
		}
		public override uint? ClassCRC => 0x3C459074;
	}
}

