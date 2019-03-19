using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_HunterHoleAIComponent_Template : AIComponent_Template {
		[Serialize("findEnemyRadius")] public float findEnemyRadius;
		[Serialize("useRadius"      )] public int useRadius;
		[Serialize("detectionRange" )] public Placeholder detectionRange;
		[Serialize("idleBehavior"   )] public Placeholder idleBehavior;
		[Serialize("attackBehavior" )] public Placeholder attackBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(findEnemyRadius));
			SerializeField(s, nameof(useRadius));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(idleBehavior));
			SerializeField(s, nameof(attackBehavior));
		}
		public override uint? ClassCRC => 0x6165B732;
	}
}

