using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BreakableAIComponent_Template : RO2_AIComponent_Template {
		public Generic<RO2_EventSpawnReward> reward2;
		public uint crushAttackDamage;
		public uint frontDamage;
		public uint backDamage;
		public Angle hitAngleOffset;
		public Angle hitAngleMinIncidence;
		public StringID restoreAnim;
		public bool checkHitSenderDirection;
		public CListO<RO2_BreakableAIComponent_Template.DestructionStage> destructionStages;
		public StringID openAnim;
		public StringID openAnimReverse;
		public bool resetOnCheckpoint;
		public bool isTouchTapSensitive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward2 = s.SerializeObject<Generic<RO2_EventSpawnReward>>(reward2, name: "reward");
			crushAttackDamage = s.Serialize<uint>(crushAttackDamage, name: "crushAttackDamage");
			frontDamage = s.Serialize<uint>(frontDamage, name: "frontDamage");
			backDamage = s.Serialize<uint>(backDamage, name: "backDamage");
			hitAngleOffset = s.SerializeObject<Angle>(hitAngleOffset, name: "hitAngleOffset");
			hitAngleMinIncidence = s.SerializeObject<Angle>(hitAngleMinIncidence, name: "hitAngleMinIncidence");
			restoreAnim = s.SerializeObject<StringID>(restoreAnim, name: "restoreAnim");
			checkHitSenderDirection = s.Serialize<bool>(checkHitSenderDirection, name: "checkHitSenderDirection");
			destructionStages = s.SerializeObject<CListO<RO2_BreakableAIComponent_Template.DestructionStage>>(destructionStages, name: "destructionStages");
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			openAnimReverse = s.SerializeObject<StringID>(openAnimReverse, name: "openAnimReverse");
			resetOnCheckpoint = s.Serialize<bool>(resetOnCheckpoint, name: "resetOnCheckpoint");
			isTouchTapSensitive = s.Serialize<bool>(isTouchTapSensitive, name: "isTouchTapSensitive");
		}
		[Games(GameFlags.RL | GameFlags.RA)]
		public partial class DestructionStage : CSerializable {
			public StringID rumble;
			public StringID destroy;
			public StringID destroyReverse;
			public StringID stand;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				rumble = s.SerializeObject<StringID>(rumble, name: "rumble");
				destroy = s.SerializeObject<StringID>(destroy, name: "destroy");
				destroyReverse = s.SerializeObject<StringID>(destroyReverse, name: "destroyReverse");
				stand = s.SerializeObject<StringID>(stand, name: "stand");
			}
		}
		public override uint? ClassCRC => 0x093BDC7B;
	}
}

