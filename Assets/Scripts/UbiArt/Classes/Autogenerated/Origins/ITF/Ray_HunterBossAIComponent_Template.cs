using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_HunterBossAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("idleBehavior"       )] public Placeholder idleBehavior;
		[Serialize("attackBehavior"     )] public Placeholder attackBehavior;
		[Serialize("holeAttackBehavior" )] public Placeholder holeAttackBehavior;
		[Serialize("receiveHitBehavior" )] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"      )] public Placeholder deathBehavior;
		[Serialize("closeRangeBehavior" )] public Placeholder closeRangeBehavior;
		[Serialize("crushedBehavior"    )] public Placeholder crushedBehavior;
		[Serialize("voidBehavior"       )] public Placeholder voidBehavior;
		[Serialize("findEnemyRadius"    )] public float findEnemyRadius;
		[Serialize("closeRadius"        )] public float closeRadius;
		[Serialize("useRadius"          )] public bool useRadius;
		[Serialize("detectionRange"     )] public Placeholder detectionRange;
		[Serialize("detectionCloseRange")] public Placeholder detectionCloseRange;
		[Serialize("healthBeforeChange" )] public uint healthBeforeChange;
		[Serialize("maxNodes"           )] public uint maxNodes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idleBehavior));
			SerializeField(s, nameof(attackBehavior));
			SerializeField(s, nameof(holeAttackBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(closeRangeBehavior));
			SerializeField(s, nameof(crushedBehavior));
			SerializeField(s, nameof(voidBehavior));
			SerializeField(s, nameof(findEnemyRadius));
			SerializeField(s, nameof(closeRadius));
			SerializeField(s, nameof(useRadius));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(detectionCloseRange));
			SerializeField(s, nameof(healthBeforeChange));
			SerializeField(s, nameof(maxNodes));
		}
		public override uint? ClassCRC => 0xDFA8946A;
	}
}

