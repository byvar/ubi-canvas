using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BreakableAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("reward"                 )] public Placeholder reward;
		[Serialize("crushAttackDamage"      )] public uint crushAttackDamage;
		[Serialize("frontDamage"            )] public uint frontDamage;
		[Serialize("backDamage"             )] public uint backDamage;
		[Serialize("hitAngleOffset"         )] public Angle hitAngleOffset;
		[Serialize("hitAngleMinIncidence"   )] public Angle hitAngleMinIncidence;
		[Serialize("restoreAnim"            )] public StringID restoreAnim;
		[Serialize("checkHitSenderDirection")] public bool checkHitSenderDirection;
		[Serialize("destructionStages"      )] public Placeholder destructionStages;
		[Serialize("openAnim"               )] public StringID openAnim;
		[Serialize("openAnimReverse"        )] public StringID openAnimReverse;
		[Serialize("resetOnCheckpoint"      )] public bool resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(crushAttackDamage));
			SerializeField(s, nameof(frontDamage));
			SerializeField(s, nameof(backDamage));
			SerializeField(s, nameof(hitAngleOffset));
			SerializeField(s, nameof(hitAngleMinIncidence));
			SerializeField(s, nameof(restoreAnim));
			SerializeField(s, nameof(checkHitSenderDirection));
			SerializeField(s, nameof(destructionStages));
			SerializeField(s, nameof(openAnim));
			SerializeField(s, nameof(openAnimReverse));
			SerializeField(s, nameof(resetOnCheckpoint));
		}
		public override uint? ClassCRC => 0x4ABB0FC9;
	}
}

