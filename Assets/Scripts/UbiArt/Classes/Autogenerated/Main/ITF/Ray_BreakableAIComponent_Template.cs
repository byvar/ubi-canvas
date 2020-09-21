using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableAIComponent_Template : Ray_AIComponent_Template {
		public Generic<Ray_EventSpawnReward> reward2;
		public uint crushAttackDamage;
		public uint frontDamage;
		public uint backDamage;
		public Angle hitAngleOffset;
		public Angle hitAngleMinIncidence;
		public StringID restoreAnim;
		public int checkHitSenderDirection;
		public CArrayO<Ray_BreakableAIComponent_Template.DestructionStage> destructionStages;
		public StringID openAnim;
		public StringID openAnimReverse;
		public int resetOnCheckpoint;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			reward2 = s.SerializeObject<Generic<Ray_EventSpawnReward>>(reward2, name: "reward2");
			crushAttackDamage = s.Serialize<uint>(crushAttackDamage, name: "crushAttackDamage");
			frontDamage = s.Serialize<uint>(frontDamage, name: "frontDamage");
			backDamage = s.Serialize<uint>(backDamage, name: "backDamage");
			hitAngleOffset = s.SerializeObject<Angle>(hitAngleOffset, name: "hitAngleOffset");
			hitAngleMinIncidence = s.SerializeObject<Angle>(hitAngleMinIncidence, name: "hitAngleMinIncidence");
			restoreAnim = s.SerializeObject<StringID>(restoreAnim, name: "restoreAnim");
			checkHitSenderDirection = s.Serialize<int>(checkHitSenderDirection, name: "checkHitSenderDirection");
			destructionStages = s.SerializeObject<CArrayO<Ray_BreakableAIComponent_Template.DestructionStage>>(destructionStages, name: "destructionStages");
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			openAnimReverse = s.SerializeObject<StringID>(openAnimReverse, name: "openAnimReverse");
			resetOnCheckpoint = s.Serialize<int>(resetOnCheckpoint, name: "resetOnCheckpoint");
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class DestructionStage : CSerializable {
			public StringID StringID__0;
			public StringID StringID__1;
			public StringID StringID__2;
			public StringID StringID__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
				StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			}
		}
		public override uint? ClassCRC => 0x4ABB0FC9;
	}
}

