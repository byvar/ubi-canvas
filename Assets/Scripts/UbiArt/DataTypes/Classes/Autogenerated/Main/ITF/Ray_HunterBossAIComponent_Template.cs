using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_HunterBossAIComponent_Template : Ray_AIComponent_Template {
		public Placeholder idleBehavior;
		public Placeholder attackBehavior;
		public Placeholder holeAttackBehavior;
		public Placeholder receiveHitBehavior;
		public Placeholder deathBehavior;
		public Placeholder closeRangeBehavior;
		public Placeholder crushedBehavior;
		public Placeholder voidBehavior;
		public float findEnemyRadius;
		public float closeRadius;
		public int useRadius;
		public Placeholder detectionRange;
		public Placeholder detectionCloseRange;
		public uint healthBeforeChange;
		public uint maxNodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleBehavior = s.SerializeObject<Placeholder>(idleBehavior, name: "idleBehavior");
			attackBehavior = s.SerializeObject<Placeholder>(attackBehavior, name: "attackBehavior");
			holeAttackBehavior = s.SerializeObject<Placeholder>(holeAttackBehavior, name: "holeAttackBehavior");
			receiveHitBehavior = s.SerializeObject<Placeholder>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Placeholder>(deathBehavior, name: "deathBehavior");
			closeRangeBehavior = s.SerializeObject<Placeholder>(closeRangeBehavior, name: "closeRangeBehavior");
			crushedBehavior = s.SerializeObject<Placeholder>(crushedBehavior, name: "crushedBehavior");
			voidBehavior = s.SerializeObject<Placeholder>(voidBehavior, name: "voidBehavior");
			findEnemyRadius = s.Serialize<float>(findEnemyRadius, name: "findEnemyRadius");
			closeRadius = s.Serialize<float>(closeRadius, name: "closeRadius");
			useRadius = s.Serialize<int>(useRadius, name: "useRadius");
			detectionRange = s.SerializeObject<Placeholder>(detectionRange, name: "detectionRange");
			detectionCloseRange = s.SerializeObject<Placeholder>(detectionCloseRange, name: "detectionCloseRange");
			healthBeforeChange = s.Serialize<uint>(healthBeforeChange, name: "healthBeforeChange");
			maxNodes = s.Serialize<uint>(maxNodes, name: "maxNodes");
		}
		public override uint? ClassCRC => 0xDFA8946A;
	}
}

