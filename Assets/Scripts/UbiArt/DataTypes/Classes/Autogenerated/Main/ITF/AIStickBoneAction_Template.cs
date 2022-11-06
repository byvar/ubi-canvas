using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AIStickBoneAction_Template : AIAction_Template {
		public StringID aiStickBoneName;
		public bool aiStickBoneEnd;
		public float aiStickBoneTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			aiStickBoneName = s.SerializeObject<StringID>(aiStickBoneName, name: "aiStickBoneName");
			aiStickBoneEnd = s.Serialize<bool>(aiStickBoneEnd, name: "aiStickBoneEnd");
			aiStickBoneTime = s.Serialize<float>(aiStickBoneTime, name: "aiStickBoneTime");
		}
		public override uint? ClassCRC => 0x3C459074;
	}
}

