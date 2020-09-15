using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleActionBarComponent_Template : CSerializable {
		public int blinkIconBeforeAction;
		public float portraitScaleEffectMultiplier;
		public float scaleUpTime;
		public float scaleDownTime;
		public int zPriorityWhenTargeted;
		public int zPriorityWhenSelectingAction;
		public int zPriorityWithIgniculus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			blinkIconBeforeAction = s.Serialize<int>(blinkIconBeforeAction, name: "blinkIconBeforeAction");
			portraitScaleEffectMultiplier = s.Serialize<float>(portraitScaleEffectMultiplier, name: "portraitScaleEffectMultiplier");
			scaleUpTime = s.Serialize<float>(scaleUpTime, name: "scaleUpTime");
			scaleDownTime = s.Serialize<float>(scaleDownTime, name: "scaleDownTime");
			zPriorityWhenTargeted = s.Serialize<int>(zPriorityWhenTargeted, name: "zPriorityWhenTargeted");
			zPriorityWhenSelectingAction = s.Serialize<int>(zPriorityWhenSelectingAction, name: "zPriorityWhenSelectingAction");
			zPriorityWithIgniculus = s.Serialize<int>(zPriorityWithIgniculus, name: "zPriorityWithIgniculus");
		}
		public override uint? ClassCRC => 0x67126EAE;
	}
}

