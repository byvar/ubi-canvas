using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BattleActionBarComponent_Template : CSerializable {
		[Serialize("blinkIconBeforeAction"        )] public int blinkIconBeforeAction;
		[Serialize("portraitScaleEffectMultiplier")] public float portraitScaleEffectMultiplier;
		[Serialize("scaleUpTime"                  )] public float scaleUpTime;
		[Serialize("scaleDownTime"                )] public float scaleDownTime;
		[Serialize("zPriorityWhenTargeted"        )] public int zPriorityWhenTargeted;
		[Serialize("zPriorityWhenSelectingAction" )] public int zPriorityWhenSelectingAction;
		[Serialize("zPriorityWithIgniculus"       )] public int zPriorityWithIgniculus;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(blinkIconBeforeAction));
			SerializeField(s, nameof(portraitScaleEffectMultiplier));
			SerializeField(s, nameof(scaleUpTime));
			SerializeField(s, nameof(scaleDownTime));
			SerializeField(s, nameof(zPriorityWhenTargeted));
			SerializeField(s, nameof(zPriorityWhenSelectingAction));
			SerializeField(s, nameof(zPriorityWithIgniculus));
		}
		public override uint? ClassCRC => 0x67126EAE;
	}
}

