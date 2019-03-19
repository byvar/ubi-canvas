using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakableAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("reward"                 )] public Generic<RO2_EventSpawnReward> reward;
		[Serialize("crushAttackDamage"      )] public uint crushAttackDamage;
		[Serialize("frontDamage"            )] public uint frontDamage;
		[Serialize("backDamage"             )] public uint backDamage;
		[Serialize("hitAngleOffset"         )] public Angle hitAngleOffset;
		[Serialize("hitAngleMinIncidence"   )] public Angle hitAngleMinIncidence;
		[Serialize("restoreAnim"            )] public StringID restoreAnim;
		[Serialize("checkHitSenderDirection")] public bool checkHitSenderDirection;
		[Serialize("destructionStages"      )] public CList<RO2_BreakableAIComponent_Template.DestructionStage> destructionStages;
		[Serialize("openAnim"               )] public StringID openAnim;
		[Serialize("openAnimReverse"        )] public StringID openAnimReverse;
		[Serialize("resetOnCheckpoint"      )] public bool resetOnCheckpoint;
		[Serialize("isTouchTapSensitive"    )] public bool isTouchTapSensitive;
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
			SerializeField(s, nameof(isTouchTapSensitive));
		}
		[Games(GameFlags.RA)]
		public partial class DestructionStage : CSerializable {
			[Serialize("rumble"        )] public StringID rumble;
			[Serialize("destroy"       )] public StringID destroy;
			[Serialize("destroyReverse")] public StringID destroyReverse;
			[Serialize("stand"         )] public StringID stand;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(rumble));
				SerializeField(s, nameof(destroy));
				SerializeField(s, nameof(destroyReverse));
				SerializeField(s, nameof(stand));
			}
		}
		public override uint? ClassCRC => 0x093BDC7B;
	}
}

