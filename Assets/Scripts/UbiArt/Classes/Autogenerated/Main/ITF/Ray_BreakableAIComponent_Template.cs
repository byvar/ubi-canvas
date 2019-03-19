using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("reward"                 )] public Generic<Ray_EventSpawnReward> reward;
		[Serialize("crushAttackDamage"      )] public uint crushAttackDamage;
		[Serialize("frontDamage"            )] public uint frontDamage;
		[Serialize("backDamage"             )] public uint backDamage;
		[Serialize("hitAngleOffset"         )] public Angle hitAngleOffset;
		[Serialize("hitAngleMinIncidence"   )] public Angle hitAngleMinIncidence;
		[Serialize("restoreAnim"            )] public StringID restoreAnim;
		[Serialize("checkHitSenderDirection")] public int checkHitSenderDirection;
		[Serialize("destructionStages"      )] public CArray<Ray_BreakableAIComponent_Template.DestructionStage> destructionStages;
		[Serialize("openAnim"               )] public StringID openAnim;
		[Serialize("openAnimReverse"        )] public StringID openAnimReverse;
		[Serialize("resetOnCheckpoint"      )] public int resetOnCheckpoint;
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
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class DestructionStage : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			[Serialize("StringID__2")] public StringID StringID__2;
			[Serialize("StringID__3")] public StringID StringID__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(StringID__3));
			}
		}
		public override uint? ClassCRC => 0x4ABB0FC9;
	}
}

